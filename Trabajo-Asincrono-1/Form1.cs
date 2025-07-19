namespace Trabajo_Asincrono_1
{
    public partial class Form1 : Form
    {
        // Lista de todas las líneas activas en la simulación
        private List<Produccion> _lineas = new();
        // Diccionarios para asociar cada línea con sus controles de UI, los diccionarios san claves para que los cambios vayan a la linea, pb o estado que debe de ir
        private Dictionary<Produccion, ProgressBar> _pbLinea = new();
        private Dictionary<Produccion, Label> _lblProdLinea = new();
        private Dictionary<Produccion, Label> _lblEstadoLinea = new();
        // Fuente de cancelación para detener la producción cuando sea necesario
        private CancellationTokenSource cts;
        //Objeto de tipo random, para randomizar diferentes cosas
        private Random rnd = new();
        // Límites del número de líneas que pueden mostrarse
        private int MIN_LINEAS = 2;
        private int MAX_LINEAS = 5;
        public Form1()
        {
            InitializeComponent();
            // Al arrancar se crean las líneas Alpha y Beta
            txt_NumeroLineas.Text = MIN_LINEAS.ToString();              
            btn_MenosLineas.Enabled = false;           
            btn_CancelarProduccion.Enabled = false;
            ConstruirFilas(MIN_LINEAS);
        }
        /// Devuelve el número de líneas indicado por el usuario validando
        /// que se encuentre dentro del rango permitido
        private int ObtenerNumeroLineas()
        {
            if (!int.TryParse(txt_NumeroLineas.Text, out int valor))
                valor = MIN_LINEAS;

            // Ajustamos para que nunca baje de MIN_LINEAS ni pase de MAX_LINEAS usando Math.Clamp
            return Math.Clamp(valor, MIN_LINEAS, MAX_LINEAS);
        }

        /// Actualiza el TextBox y habilita / deshabilita “+” y “–”
        private void EstablecerNumeroLineas(int valor)
        {
            valor = Math.Clamp(valor, MIN_LINEAS, MAX_LINEAS);
            txt_NumeroLineas.Text = valor.ToString();

            // Si llegamos al máximo, el botón “+” se apaga; si llegamos al mínimo, el “–” se apaga.
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
                ConstruirFilas(n); // Preparamos la mesa con la nueva cantidad de filas
            }
        }

        private void btn_MenosLineas_Click(object sender, EventArgs e)
        {
            int n = ObtenerNumeroLineas();
            if (n > MIN_LINEAS) // No bajamos de dos líneas.
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
            //array que guarda las etiquetas de cada linea
            string[] nombres = {
        "Línea Alpha", "Línea Beta", "Línea Gamma",
        "Línea Delta", "Línea Epsilon"
    };
            // Creamos tantas líneas como pidió la persona
            for (int i = 0; i < cantidad; i++)
            {
                // 80-150 productos aleatorios para la demo
                var linea = new Produccion(nombres[i], rnd.Next(80, 151));
                _lineas.Add(linea);

                // Columna 0: nombre 
                var lblNombre = new Label
                {
                    Text = linea.Nombre,
                    Anchor = AnchorStyles.Left,
                    AutoSize = true
                };

                //  Columna 1: barra 
                var pb = new ProgressBar
                {
                    Maximum = 100,
                    Dock = DockStyle.Fill,
                    Style = ProgressBarStyle.Continuous
                };

                // Columna 2: contador 
                var lblProd = new Label
                {
                    Text = $"0 / {linea.TotalDeItems}",
                    Anchor = AnchorStyles.Left,
                    AutoSize = true
                };
                // Columna 3 Estado
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

            tlp_Lineas.ResumeLayout(); // Se resume el layout despues de haber creado las lineas

            // Calculamos el total global y lo mostramos.
            int total = _lineas.Sum(l => l.TotalDeItems);
            lbl_Total.Text = $"0 / {total} productos";
            pgb_TotalProgreso.Value = 0;
        }

        private async void btn_IniciarProduccion_Click(object sender, EventArgs e)
        {
            // Bloqueamos controles para que nadie cambie los números a mitad de camino
            btn_IniciarProduccion.Enabled = false;
            btn_CancelarProduccion.Enabled = true;
            btn_MasLineas.Enabled = btn_MenosLineas.Enabled = false;
            txt_NumeroLineas.Enabled = false;             
            lsb_Eventos.Items.Clear(); // Limpiamos el registro de mensajes.

            // Total que deben fabricar todas las líneas juntas.
            int totalGlobal = _lineas.Sum(l => l.TotalDeItems);
            int fabricadosGlo = 0;
            //Token para cancelacion de produccion
            cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;

            // Preparamos una tarea por línea.
            var tareas = _lineas.Select(linea =>
            {
                var pb = _pbLinea[linea];
                var lblP = _lblProdLinea[linea];
                var lblEstado = _lblEstadoLinea[linea];

                // Este “reporte” se dispara cada vez que la línea fabrica una pieza
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

                // Donde escribimos los avisos (25 %, 50 %, 75 %, etc.), aca se overlodea el delegado usado en <Produccion>
                Action<string> log = msg =>
                {
                    lsb_Eventos.Items.Add($"• {msg}");
                    lsb_Eventos.TopIndex = lsb_Eventos.Items.Count - 1; // autoscroll
                };
                // Lanzamos la producción y al final cambiamos el texto de estado.
                return linea.RunAsync(prog, log, ct)
                .ContinueWith(t =>
                 {
                     if (t.IsCanceled)
                         lblEstado.Text = "Cancelada";
                     else if (t.IsCompletedSuccessfully)
                         lblEstado.Text = "Completada ";
                 }, TaskScheduler.FromCurrentSynchronizationContext());
            });

            // Esperamos a que todas las líneas terminen (o se cancelen).
            try
            {
                await Task.WhenAll(tareas);
                if (cts.IsCancellationRequested) 
                { 
                    lsb_Eventos.Items.Add("Producción cancelada por el usuario."); 
                }
                else
                {
                    lsb_Eventos.Items.Add(" Todas las líneas terminaron.");
                }
                
            }
            catch (OperationCanceledException)
            {
                //Dejado Sin Efecto
            }
            // Restauramos los botones para la próxima ronda.
            finally
            {
                
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
            cts.Cancel(); // Cancelacion de la produccion
            btn_CancelarProduccion.Enabled = false; // Evita pulsarlo varias veces.
        }
    }
}
