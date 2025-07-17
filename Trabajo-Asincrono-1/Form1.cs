namespace Trabajo_Asincrono_1
{
    public partial class Form1 : Form
    {
        private List<Produccion> _lineas = new();
        private Dictionary<Produccion, ProgressBar> _pbLinea = new();
        private Dictionary<Produccion, Label> _lblProdLinea = new();
        private CancellationTokenSource? _cts;
        private Random _rnd = new();
        private const int MIN_LINEAS = 2;
        private const int MAX_LINEAS = 5;
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
    }
}
