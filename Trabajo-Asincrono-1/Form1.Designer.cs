namespace Trabajo_Asincrono_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_IniciarProduccion = new Button();
            btn_CancelarProduccion = new Button();
            lbl_Nombre = new Label();
            txt_NumeroLineas = new TextBox();
            btn_MasLineas = new Button();
            btn_MenosLineas = new Button();
            pgb_TotalProgreso = new ProgressBar();
            lbl_Lineas = new Label();
            lbl_ProgresoLineas = new Label();
            lbl_EstadoLineas = new Label();
            lbl_TotalProgreso = new Label();
            lbl_Eventos = new Label();
            lbl_PorcentajeTotal = new Label();
            tlp_Lineas = new TableLayoutPanel();
            panel1 = new Panel();
            lbl_Total = new Label();
            lsb_Eventos = new ListBox();
            lbl_Nmerolin = new Label();
            lbl_Productos = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_IniciarProduccion
            // 
            btn_IniciarProduccion.Location = new Point(459, 48);
            btn_IniciarProduccion.Name = "btn_IniciarProduccion";
            btn_IniciarProduccion.Size = new Size(154, 29);
            btn_IniciarProduccion.TabIndex = 1;
            btn_IniciarProduccion.Text = "Iniciar Producción";
            btn_IniciarProduccion.UseVisualStyleBackColor = true;
            btn_IniciarProduccion.Click += btn_IniciarProduccion_Click;
            // 
            // btn_CancelarProduccion
            // 
            btn_CancelarProduccion.Location = new Point(459, 97);
            btn_CancelarProduccion.Name = "btn_CancelarProduccion";
            btn_CancelarProduccion.Size = new Size(154, 29);
            btn_CancelarProduccion.TabIndex = 2;
            btn_CancelarProduccion.Text = "Cancelar Producción";
            btn_CancelarProduccion.UseVisualStyleBackColor = true;
            btn_CancelarProduccion.Click += btn_CancelarProduccion_Click;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(214, 21);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(212, 20);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "SIMULADOR DE PRODUCCIÓN";
            // 
            // txt_NumeroLineas
            // 
            txt_NumeroLineas.Font = new Font("Segoe UI", 11F);
            txt_NumeroLineas.Location = new Point(156, 68);
            txt_NumeroLineas.Name = "txt_NumeroLineas";
            txt_NumeroLineas.ReadOnly = true;
            txt_NumeroLineas.Size = new Size(41, 32);
            txt_NumeroLineas.TabIndex = 9;
            txt_NumeroLineas.Text = "Numero De Lineas: {2}";
            // 
            // btn_MasLineas
            // 
            btn_MasLineas.Image = (Image)resources.GetObject("btn_MasLineas.Image");
            btn_MasLineas.Location = new Point(214, 68);
            btn_MasLineas.Name = "btn_MasLineas";
            btn_MasLineas.Size = new Size(40, 32);
            btn_MasLineas.TabIndex = 10;
            btn_MasLineas.UseVisualStyleBackColor = true;
            btn_MasLineas.Click += btn_MasLineas_Click;
            // 
            // btn_MenosLineas
            // 
            btn_MenosLineas.Image = (Image)resources.GetObject("btn_MenosLineas.Image");
            btn_MenosLineas.Location = new Point(260, 69);
            btn_MenosLineas.Name = "btn_MenosLineas";
            btn_MenosLineas.Size = new Size(40, 32);
            btn_MenosLineas.TabIndex = 11;
            btn_MenosLineas.UseVisualStyleBackColor = true;
            btn_MenosLineas.Click += btn_MenosLineas_Click;
            // 
            // pgb_TotalProgreso
            // 
            pgb_TotalProgreso.Location = new Point(153, 379);
            pgb_TotalProgreso.Name = "pgb_TotalProgreso";
            pgb_TotalProgreso.Size = new Size(334, 29);
            pgb_TotalProgreso.TabIndex = 17;
            // 
            // lbl_Lineas
            // 
            lbl_Lineas.AutoSize = true;
            lbl_Lineas.Location = new Point(34, 154);
            lbl_Lineas.Name = "lbl_Lineas";
            lbl_Lineas.Size = new Size(50, 20);
            lbl_Lineas.TabIndex = 18;
            lbl_Lineas.Text = "Lineas";
            // 
            // lbl_ProgresoLineas
            // 
            lbl_ProgresoLineas.AutoSize = true;
            lbl_ProgresoLineas.Location = new Point(297, 151);
            lbl_ProgresoLineas.Name = "lbl_ProgresoLineas";
            lbl_ProgresoLineas.Size = new Size(68, 20);
            lbl_ProgresoLineas.TabIndex = 19;
            lbl_ProgresoLineas.Text = "Progreso";
            // 
            // lbl_EstadoLineas
            // 
            lbl_EstadoLineas.AutoSize = true;
            lbl_EstadoLineas.Location = new Point(616, 151);
            lbl_EstadoLineas.Name = "lbl_EstadoLineas";
            lbl_EstadoLineas.Size = new Size(54, 20);
            lbl_EstadoLineas.TabIndex = 20;
            lbl_EstadoLineas.Text = "Estado";
            // 
            // lbl_TotalProgreso
            // 
            lbl_TotalProgreso.AutoSize = true;
            lbl_TotalProgreso.Location = new Point(34, 388);
            lbl_TotalProgreso.Name = "lbl_TotalProgreso";
            lbl_TotalProgreso.Size = new Size(105, 20);
            lbl_TotalProgreso.TabIndex = 26;
            lbl_TotalProgreso.Text = "Progreso Total";
            // 
            // lbl_Eventos
            // 
            lbl_Eventos.AutoSize = true;
            lbl_Eventos.Location = new Point(13, 460);
            lbl_Eventos.Name = "lbl_Eventos";
            lbl_Eventos.Size = new Size(146, 20);
            lbl_Eventos.TabIndex = 27;
            lbl_Eventos.Text = " Registro De Eventos";
            // 
            // lbl_PorcentajeTotal
            // 
            lbl_PorcentajeTotal.AutoSize = true;
            lbl_PorcentajeTotal.Location = new Point(498, 386);
            lbl_PorcentajeTotal.Name = "lbl_PorcentajeTotal";
            lbl_PorcentajeTotal.Size = new Size(0, 20);
            lbl_PorcentajeTotal.TabIndex = 33;
            // 
            // tlp_Lineas
            // 
            tlp_Lineas.AutoSize = true;
            tlp_Lineas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_Lineas.ColumnCount = 4;
            tlp_Lineas.ColumnStyles.Add(new ColumnStyle());
            tlp_Lineas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_Lineas.ColumnStyles.Add(new ColumnStyle());
            tlp_Lineas.ColumnStyles.Add(new ColumnStyle());
            tlp_Lineas.Dock = DockStyle.Top;
            tlp_Lineas.Location = new Point(0, 0);
            tlp_Lineas.Name = "tlp_Lineas";
            tlp_Lineas.RowCount = 1;
            tlp_Lineas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_Lineas.Size = new Size(677, 0);
            tlp_Lineas.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.Controls.Add(tlp_Lineas);
            panel1.Location = new Point(2, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 159);
            panel1.TabIndex = 41;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Location = new Point(516, 386);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(50, 20);
            lbl_Total.TabIndex = 42;
            lbl_Total.Text = "label1";
            // 
            // lsb_Eventos
            // 
            lsb_Eventos.FormattingEnabled = true;
            lsb_Eventos.Location = new Point(2, 492);
            lsb_Eventos.Name = "lsb_Eventos";
            lsb_Eventos.Size = new Size(668, 204);
            lsb_Eventos.TabIndex = 43;
            // 
            // lbl_Nmerolin
            // 
            lbl_Nmerolin.AutoSize = true;
            lbl_Nmerolin.Location = new Point(8, 76);
            lbl_Nmerolin.Name = "lbl_Nmerolin";
            lbl_Nmerolin.Size = new Size(131, 20);
            lbl_Nmerolin.TabIndex = 44;
            lbl_Nmerolin.Text = "Numero De Lineas";
            // 
            // lbl_Productos
            // 
            lbl_Productos.AutoSize = true;
            lbl_Productos.Location = new Point(533, 151);
            lbl_Productos.Name = "lbl_Productos";
            lbl_Productos.Size = new Size(75, 20);
            lbl_Productos.TabIndex = 45;
            lbl_Productos.Text = "Productos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(682, 708);
            Controls.Add(lbl_Productos);
            Controls.Add(lbl_Nmerolin);
            Controls.Add(lsb_Eventos);
            Controls.Add(lbl_Total);
            Controls.Add(panel1);
            Controls.Add(lbl_PorcentajeTotal);
            Controls.Add(lbl_Eventos);
            Controls.Add(lbl_TotalProgreso);
            Controls.Add(lbl_EstadoLineas);
            Controls.Add(lbl_ProgresoLineas);
            Controls.Add(lbl_Lineas);
            Controls.Add(pgb_TotalProgreso);
            Controls.Add(btn_MenosLineas);
            Controls.Add(btn_MasLineas);
            Controls.Add(txt_NumeroLineas);
            Controls.Add(lbl_Nombre);
            Controls.Add(btn_CancelarProduccion);
            Controls.Add(btn_IniciarProduccion);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_IniciarProduccion;
        private Button btn_CancelarProduccion;
        private Label lbl_Nombre;
        private TextBox txt_NumeroLineas;
        private Button btn_MasLineas;
        private Button btn_MenosLineas;
        private ProgressBar pgb_TotalProgreso;
        private Label lbl_Lineas;
        private Label lbl_ProgresoLineas;
        private Label lbl_EstadoLineas;
        private Label lbl_TotalProgreso;
        private Label lbl_Eventos;
        private Label lbl_PorcentajeTotal;
        private TableLayoutPanel tlp_Lineas;
        private Panel panel1;
        private Label lbl_Total;
        private ListBox lsb_Eventos;
        private Label lbl_Nmerolin;
        private Label lbl_Productos;
    }
}
