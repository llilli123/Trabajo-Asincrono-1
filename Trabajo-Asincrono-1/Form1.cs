namespace Trabajo_Asincrono_1
{
    public partial class Form1 : Form
    {
        private List<Produccion> _lineas = new();
        private Dictionary<Produccion, ProgressBar> _pbLinea = new();
        private Dictionary<Produccion, Label> _lblProdLinea = new();
        private Dictionary<Produccion, Label> _lblEstadoLinea = new();
        private CancellationTokenSource cts;
        private Random _rnd = new();
        private int MIN_LINEAS = 2;
        private int MAX_LINEAS = 5;
        public Form1()
        {
            InitializeComponent();

            txt_NumeroLineas.Text = MIN_LINEAS.ToString();              // Alpha y Beta al arrancar
            btn_MenosLineas.Enabled = false;           // ya estamos en el mínimo
            btn_CancelarProduccion.Enabled = false;
            ConstruirFilas(MIN_LINEAS);
        }
        /// Devuelve el número actual de líneas (valida rango; si falla, retorna MIN_LINEAS)
        private int ObtenerNumeroLineas()
        {
            if (!int.TryParse(txt_NumeroLineas.Text, out int valor))
                valor = MIN_LINEAS;

            return Math.Clamp(valor, MIN_LINEAS, MAX_LINEAS);
        }

        /// Actualiza el TextBox y habilita / deshabilita “+” y “–”
        private void EstablecerNumeroLineas(int valor)
        {
            valor = Math.Clamp(valor, MIN_LINEAS, MAX_LINEAS);
            txt_NumeroLineas.Text = valor.ToString();

            btn_MasLineas.Enabled = valor < MAX_LINEAS;
            btn_MenosLineas.Enabled = valor > MIN_LINEAS;
        }
        private void btn_MasLineas_Click(object sender, EventArgs e)
        {
            int n = ObtenerNumeroLineas();
            if (n < MAX_LINEAS)
            {
                n++;
                EstablecerNumeroLineas(n);
                ConstruirFilas(n);
            }
        }

        private void btn_MenosLineas_Click(object sender, EventArgs e)
        {
            int n = ObtenerNumeroLineas();
            if (n > MIN_LINEAS)
            {
                n--;
                EstablecerNumeroLineas(n);
                ConstruirFilas(n);
            }
        }
        private void ConstruirFilas(int cantidad)
        {
            tlp_Lineas.SuspendLayout();          // congela layout mientras modificamos
            tlp_Lineas.Controls.Clear();
            tlp_Lineas.RowStyles.Clear();

            _lineas.Clear();
            _pbLinea.Clear();
            _lblProdLinea.Clear();

            string[] nombres = {
        "Línea Alpha", "Línea Beta", "Línea Gamma",
        "Línea Delta", "Línea Epsilon"
    };

            for (int i = 0; i < cantidad; i++)
            {
                // 80-150 productos aleatorios para la demo
                var linea = new Produccion(nombres[i], _rnd.Next(80, 151));
                _lineas.Add(linea);

                // ?? Columna 0: nombre ??
                var lblNombre = new Label
                {
                    Text = linea.Nombre,
                    Anchor = AnchorStyles.Left,
                    AutoSize = true
                };

                // ?? Columna 1: barra ??
                var pb = new ProgressBar
                {
                    Maximum = 100,
                    Dock = DockStyle.Fill,
                    Style = ProgressBarStyle.Continuous
                };

                // ?? Columna 2: contador ??
                var lblProd = new Label
                {
                    Text = $"0 / {linea.TotalDeItems}",
                    Anchor = AnchorStyles.Left,
                    AutoSize = true
                };

                var lblEstado = new Label
                {
                    Text = "Pendiente",              // antes de iniciar
                    Anchor = AnchorStyles.Left,
                    AutoSize = true
                };

                // Añadir nueva fila
                tlp_Lineas.RowCount++;
                tlp_Lineas.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tlp_Lineas.Controls.Add(lblNombre, 0, i);
                tlp_Lineas.Controls.Add(pb, 1, i);
                tlp_Lineas.Controls.Add(lblProd, 2, i);
                tlp_Lineas.Controls.Add(lblEstado, 3, i);

                // Guardar referencias para actualizaciones posteriores
                _pbLinea[linea] = pb;
                _lblProdLinea[linea] = lblProd;
                _lblEstadoLinea[linea] = lblEstado;
            }

            tlp_Lineas.ResumeLayout();

            // Actualiza el total global de productos
            int total = _lineas.Sum(l => l.TotalDeItems);
            lbl_Total.Text = $"0 / {total} productos";
            pgb_TotalProgreso.Value = 0;
        }

        private async void btn_IniciarProduccion_Click(object sender, EventArgs e)
        {
            btn_IniciarProduccion.Enabled = false;
            btn_CancelarProduccion.Enabled = true;
            btn_MasLineas.Enabled = btn_MenosLineas.Enabled = false;
            txt_NumeroLineas.Enabled = false;             // evita que cambien el número a mitad
            lsb_Eventos.Items.Clear();


            int totalGlobal = _lineas.Sum(l => l.TotalDeItems);
            int fabricadosGlo = 0;

            cts = new CancellationTokenSource();

            var tareas = _lineas.Select(linea =>
            {
                var pb = _pbLinea[linea];
                var lblP = _lblProdLinea[linea];
                var lblEstado = _lblEstadoLinea[linea];

                var prog = new Progress<int>(produced =>
                {
                    pb.Value = produced * 100 / linea.TotalDeItems;
                    lblP.Text = $"{produced} / {linea.TotalDeItems}";
                    lblEstado.Text = "Produciendo";

                    // Actualizar global
                    fabricadosGlo = _lineas.Sum(l => l.Producido);
                    pgb_TotalProgreso.Value = fabricadosGlo * 100 / totalGlobal;
                    lbl_Total.Text = $"{fabricadosGlo} / {totalGlobal} productos";

                });

                Action<string> log = msg =>
                {
                    lsb_Eventos.Items.Add($"• {msg}");
                    lsb_Eventos.TopIndex = lsb_Eventos.Items.Count - 1; // autoscroll
                };

                return linea.RunAsync(prog, log, cts.Token)
                .ContinueWith(t =>
                 {
                     if (t.IsCanceled)
                         lblEstado.Text = "Cancelada";
                     else if (t.IsCompletedSuccessfully)
                         lblEstado.Text = "Completada ";
                 }, TaskScheduler.FromCurrentSynchronizationContext());
            });

            try
            {
                await Task.WhenAll(tareas);
                lsb_Eventos.Items.Add(" Todas las líneas terminaron.");
            }
            catch (OperationCanceledException)
            {
                lsb_Eventos.Items.Add("Producción cancelada por el usuario.");
            }
            finally
            {
                // Restaurar controles
                btn_IniciarProduccion.Enabled = true;
                btn_CancelarProduccion.Enabled = false;
                txt_NumeroLineas.Enabled = true;

                btn_MasLineas.Enabled = ObtenerNumeroLineas() < MAX_LINEAS;
                btn_MenosLineas.Enabled = ObtenerNumeroLineas() > MIN_LINEAS;

                cts?.Dispose();
                cts = null;
            }
        }



        private void btn_CancelarProduccion_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            btn_CancelarProduccion.Enabled = false;
        }
    }
}
