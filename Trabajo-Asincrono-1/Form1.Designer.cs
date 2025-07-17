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
            pgb_ProgresoAlpha = new ProgressBar();
            pgb_ProgresoGamma = new ProgressBar();
            pgb_ProgresoBeta = new ProgressBar();
            pgb_ProgresoDelta = new ProgressBar();
            pgb_ProgresoEpsilon = new ProgressBar();
            txt_NumeroLineas = new TextBox();
            btn_MasLineas = new Button();
            btn_MenosLineas = new Button();
            btn_CancelarAlpha = new Button();
            btn_CancelarGamma = new Button();
            btn_CancelarBeta = new Button();
            btn_CancelarDelta = new Button();
            btn_CancelarEpsilon = new Button();
            pgb_TotalProgreso = new ProgressBar();
            lbl_Lineas = new Label();
            lbl_ProgresoLineas = new Label();
            lbl_EstadoLineas = new Label();
            lbl_LineaAlpha = new Label();
            lbl_LineaBeta = new Label();
            lbl_LineaGamma = new Label();
            lbl_LineaDelta = new Label();
            lbl_LineaEpsilon = new Label();
            lbl_TotalProgreso = new Label();
            lbl_Eventos = new Label();
            lbl_EstadoEpsilon = new Label();
            lbl_EstadoDelta = new Label();
            lbl_EstadoGamma = new Label();
            lbl_EstadoBeta = new Label();
            lbl_EstadoAlpha = new Label();
            lbl_PorcentajeTotal = new Label();
            txt_EventoAlpha = new TextBox();
            txt_EventoGamma = new TextBox();
            txt_EventoBeta = new TextBox();
            txt_EventoDelta = new TextBox();
            txt_EventoEpsilon = new TextBox();
            txt_EventoTotal = new TextBox();
            tlp_Lineas = new TableLayoutPanel();
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
            // 
            // btn_CancelarProduccion
            // 
            btn_CancelarProduccion.Location = new Point(459, 97);
            btn_CancelarProduccion.Name = "btn_CancelarProduccion";
            btn_CancelarProduccion.Size = new Size(154, 29);
            btn_CancelarProduccion.TabIndex = 2;
            btn_CancelarProduccion.Text = "Cancelar Producción";
            btn_CancelarProduccion.UseVisualStyleBackColor = true;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(214, 21);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(237, 20);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "📊 SIMULADOR DE PRODUCCIÓN";
            // 
            // pgb_ProgresoAlpha
            // 
            pgb_ProgresoAlpha.Location = new Point(214, 182);
            pgb_ProgresoAlpha.Name = "pgb_ProgresoAlpha";
            pgb_ProgresoAlpha.Size = new Size(237, 29);
            pgb_ProgresoAlpha.TabIndex = 4;
            // 
            // pgb_ProgresoGamma
            // 
            pgb_ProgresoGamma.Location = new Point(214, 255);
            pgb_ProgresoGamma.Name = "pgb_ProgresoGamma";
            pgb_ProgresoGamma.Size = new Size(237, 29);
            pgb_ProgresoGamma.TabIndex = 5;
            // 
            // pgb_ProgresoBeta
            // 
            pgb_ProgresoBeta.Location = new Point(214, 217);
            pgb_ProgresoBeta.Name = "pgb_ProgresoBeta";
            pgb_ProgresoBeta.Size = new Size(237, 29);
            pgb_ProgresoBeta.TabIndex = 6;
            // 
            // pgb_ProgresoDelta
            // 
            pgb_ProgresoDelta.Location = new Point(214, 290);
            pgb_ProgresoDelta.Name = "pgb_ProgresoDelta";
            pgb_ProgresoDelta.Size = new Size(237, 29);
            pgb_ProgresoDelta.TabIndex = 7;
            // 
            // pgb_ProgresoEpsilon
            // 
            pgb_ProgresoEpsilon.Location = new Point(214, 325);
            pgb_ProgresoEpsilon.Name = "pgb_ProgresoEpsilon";
            pgb_ProgresoEpsilon.Size = new Size(237, 29);
            pgb_ProgresoEpsilon.TabIndex = 8;
            // 
            // txt_NumeroLineas
            // 
            txt_NumeroLineas.Font = new Font("Segoe UI", 11F);
            txt_NumeroLineas.Location = new Point(13, 68);
            txt_NumeroLineas.Name = "txt_NumeroLineas";
            txt_NumeroLineas.Size = new Size(184, 32);
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
            // btn_CancelarAlpha
            // 
            btn_CancelarAlpha.Location = new Point(459, 182);
            btn_CancelarAlpha.Name = "btn_CancelarAlpha";
            btn_CancelarAlpha.Size = new Size(40, 29);
            btn_CancelarAlpha.TabIndex = 12;
            btn_CancelarAlpha.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarGamma
            // 
            btn_CancelarGamma.Location = new Point(459, 255);
            btn_CancelarGamma.Name = "btn_CancelarGamma";
            btn_CancelarGamma.Size = new Size(40, 29);
            btn_CancelarGamma.TabIndex = 13;
            btn_CancelarGamma.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarBeta
            // 
            btn_CancelarBeta.Location = new Point(459, 217);
            btn_CancelarBeta.Name = "btn_CancelarBeta";
            btn_CancelarBeta.Size = new Size(40, 29);
            btn_CancelarBeta.TabIndex = 14;
            btn_CancelarBeta.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarDelta
            // 
            btn_CancelarDelta.Location = new Point(459, 290);
            btn_CancelarDelta.Name = "btn_CancelarDelta";
            btn_CancelarDelta.Size = new Size(40, 29);
            btn_CancelarDelta.TabIndex = 15;
            btn_CancelarDelta.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarEpsilon
            // 
            btn_CancelarEpsilon.Location = new Point(459, 325);
            btn_CancelarEpsilon.Name = "btn_CancelarEpsilon";
            btn_CancelarEpsilon.Size = new Size(40, 29);
            btn_CancelarEpsilon.TabIndex = 16;
            btn_CancelarEpsilon.UseVisualStyleBackColor = true;
            // 
            // pgb_TotalProgreso
            // 
            pgb_TotalProgreso.Location = new Point(181, 393);
            pgb_TotalProgreso.Name = "pgb_TotalProgreso";
            pgb_TotalProgreso.Size = new Size(334, 29);
            pgb_TotalProgreso.TabIndex = 17;
            // 
            // lbl_Lineas
            // 
            lbl_Lineas.AutoSize = true;
            lbl_Lineas.Location = new Point(62, 151);
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
            lbl_EstadoLineas.Location = new Point(524, 151);
            lbl_EstadoLineas.Name = "lbl_EstadoLineas";
            lbl_EstadoLineas.Size = new Size(54, 20);
            lbl_EstadoLineas.TabIndex = 20;
            lbl_EstadoLineas.Text = "Estado";
            // 
            // lbl_LineaAlpha
            // 
            lbl_LineaAlpha.AutoSize = true;
            lbl_LineaAlpha.Location = new Point(62, 186);
            lbl_LineaAlpha.Name = "lbl_LineaAlpha";
            lbl_LineaAlpha.Size = new Size(87, 20);
            lbl_LineaAlpha.TabIndex = 21;
            lbl_LineaAlpha.Text = "Linea Alpha";
            // 
            // lbl_LineaBeta
            // 
            lbl_LineaBeta.AutoSize = true;
            lbl_LineaBeta.Location = new Point(62, 226);
            lbl_LineaBeta.Name = "lbl_LineaBeta";
            lbl_LineaBeta.Size = new Size(78, 20);
            lbl_LineaBeta.TabIndex = 22;
            lbl_LineaBeta.Text = "Linea Beta";
            // 
            // lbl_LineaGamma
            // 
            lbl_LineaGamma.AutoSize = true;
            lbl_LineaGamma.Location = new Point(62, 264);
            lbl_LineaGamma.Name = "lbl_LineaGamma";
            lbl_LineaGamma.Size = new Size(100, 20);
            lbl_LineaGamma.TabIndex = 23;
            lbl_LineaGamma.Text = "Linea Gamma";
            // 
            // lbl_LineaDelta
            // 
            lbl_LineaDelta.AutoSize = true;
            lbl_LineaDelta.Location = new Point(62, 299);
            lbl_LineaDelta.Name = "lbl_LineaDelta";
            lbl_LineaDelta.Size = new Size(84, 20);
            lbl_LineaDelta.TabIndex = 24;
            lbl_LineaDelta.Text = "Linea Delta";
            // 
            // lbl_LineaEpsilon
            // 
            lbl_LineaEpsilon.AutoSize = true;
            lbl_LineaEpsilon.Location = new Point(62, 334);
            lbl_LineaEpsilon.Name = "lbl_LineaEpsilon";
            lbl_LineaEpsilon.Size = new Size(96, 20);
            lbl_LineaEpsilon.TabIndex = 25;
            lbl_LineaEpsilon.Text = "Linea Epsilon";
            // 
            // lbl_TotalProgreso
            // 
            lbl_TotalProgreso.AutoSize = true;
            lbl_TotalProgreso.Location = new Point(62, 402);
            lbl_TotalProgreso.Name = "lbl_TotalProgreso";
            lbl_TotalProgreso.Size = new Size(105, 20);
            lbl_TotalProgreso.TabIndex = 26;
            lbl_TotalProgreso.Text = "Progreso Total";
            // 
            // lbl_Eventos
            // 
            lbl_Eventos.AutoSize = true;
            lbl_Eventos.Location = new Point(62, 457);
            lbl_Eventos.Name = "lbl_Eventos";
            lbl_Eventos.Size = new Size(167, 20);
            lbl_Eventos.TabIndex = 27;
            lbl_Eventos.Text = "📝 Registro De Eventos";
            // 
            // lbl_EstadoEpsilon
            // 
            lbl_EstadoEpsilon.AutoSize = true;
            lbl_EstadoEpsilon.Location = new Point(524, 334);
            lbl_EstadoEpsilon.Name = "lbl_EstadoEpsilon";
            lbl_EstadoEpsilon.Size = new Size(58, 20);
            lbl_EstadoEpsilon.TabIndex = 32;
            lbl_EstadoEpsilon.Text = "label12";
            // 
            // lbl_EstadoDelta
            // 
            lbl_EstadoDelta.AutoSize = true;
            lbl_EstadoDelta.Location = new Point(524, 299);
            lbl_EstadoDelta.Name = "lbl_EstadoDelta";
            lbl_EstadoDelta.Size = new Size(58, 20);
            lbl_EstadoDelta.TabIndex = 31;
            lbl_EstadoDelta.Text = "label13";
            // 
            // lbl_EstadoGamma
            // 
            lbl_EstadoGamma.AutoSize = true;
            lbl_EstadoGamma.Location = new Point(524, 264);
            lbl_EstadoGamma.Name = "lbl_EstadoGamma";
            lbl_EstadoGamma.Size = new Size(58, 20);
            lbl_EstadoGamma.TabIndex = 30;
            lbl_EstadoGamma.Text = "label14";
            // 
            // lbl_EstadoBeta
            // 
            lbl_EstadoBeta.AutoSize = true;
            lbl_EstadoBeta.Location = new Point(524, 226);
            lbl_EstadoBeta.Name = "lbl_EstadoBeta";
            lbl_EstadoBeta.Size = new Size(58, 20);
            lbl_EstadoBeta.TabIndex = 29;
            lbl_EstadoBeta.Text = "label15";
            // 
            // lbl_EstadoAlpha
            // 
            lbl_EstadoAlpha.AutoSize = true;
            lbl_EstadoAlpha.Location = new Point(524, 186);
            lbl_EstadoAlpha.Name = "lbl_EstadoAlpha";
            lbl_EstadoAlpha.Size = new Size(58, 20);
            lbl_EstadoAlpha.TabIndex = 28;
            lbl_EstadoAlpha.Text = "label16";
            // 
            // lbl_PorcentajeTotal
            // 
            lbl_PorcentajeTotal.AutoSize = true;
            lbl_PorcentajeTotal.Location = new Point(553, 398);
            lbl_PorcentajeTotal.Name = "lbl_PorcentajeTotal";
            lbl_PorcentajeTotal.Size = new Size(29, 20);
            lbl_PorcentajeTotal.TabIndex = 33;
            lbl_PorcentajeTotal.Text = " 77";
            // 
            // txt_EventoAlpha
            // 
            txt_EventoAlpha.Location = new Point(62, 516);
            txt_EventoAlpha.Name = "txt_EventoAlpha";
            txt_EventoAlpha.Size = new Size(453, 27);
            txt_EventoAlpha.TabIndex = 34;
            // 
            // txt_EventoGamma
            // 
            txt_EventoGamma.Location = new Point(62, 582);
            txt_EventoGamma.Name = "txt_EventoGamma";
            txt_EventoGamma.Size = new Size(453, 27);
            txt_EventoGamma.TabIndex = 35;
            // 
            // txt_EventoBeta
            // 
            txt_EventoBeta.Location = new Point(62, 549);
            txt_EventoBeta.Name = "txt_EventoBeta";
            txt_EventoBeta.Size = new Size(453, 27);
            txt_EventoBeta.TabIndex = 36;
            // 
            // txt_EventoDelta
            // 
            txt_EventoDelta.Location = new Point(62, 615);
            txt_EventoDelta.Name = "txt_EventoDelta";
            txt_EventoDelta.Size = new Size(453, 27);
            txt_EventoDelta.TabIndex = 37;
            // 
            // txt_EventoEpsilon
            // 
            txt_EventoEpsilon.Location = new Point(62, 648);
            txt_EventoEpsilon.Name = "txt_EventoEpsilon";
            txt_EventoEpsilon.Size = new Size(453, 27);
            txt_EventoEpsilon.TabIndex = 38;
            // 
            // txt_EventoTotal
            // 
            txt_EventoTotal.Location = new Point(62, 483);
            txt_EventoTotal.Name = "txt_EventoTotal";
            txt_EventoTotal.Size = new Size(453, 27);
            txt_EventoTotal.TabIndex = 39;
            // 
            // tlp_Lineas
            // 
            tlp_Lineas.AutoSize = true;
            tlp_Lineas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_Lineas.ColumnCount = 3;
            tlp_Lineas.ColumnStyles.Add(new ColumnStyle());
            tlp_Lineas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_Lineas.ColumnStyles.Add(new ColumnStyle());
            tlp_Lineas.Location = new Point(50, 151);
            tlp_Lineas.Name = "tlp_Lineas";
            tlp_Lineas.RowCount = 1;
            tlp_Lineas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_Lineas.Size = new Size(0, 0);
            tlp_Lineas.TabIndex = 40;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(682, 708);
            Controls.Add(tlp_Lineas);
            Controls.Add(txt_EventoTotal);
            Controls.Add(txt_EventoEpsilon);
            Controls.Add(txt_EventoDelta);
            Controls.Add(txt_EventoBeta);
            Controls.Add(txt_EventoGamma);
            Controls.Add(txt_EventoAlpha);
            Controls.Add(lbl_PorcentajeTotal);
            Controls.Add(lbl_EstadoEpsilon);
            Controls.Add(lbl_EstadoDelta);
            Controls.Add(lbl_EstadoGamma);
            Controls.Add(lbl_EstadoBeta);
            Controls.Add(lbl_EstadoAlpha);
            Controls.Add(lbl_Eventos);
            Controls.Add(lbl_TotalProgreso);
            Controls.Add(lbl_LineaEpsilon);
            Controls.Add(lbl_LineaDelta);
            Controls.Add(lbl_LineaGamma);
            Controls.Add(lbl_LineaBeta);
            Controls.Add(lbl_LineaAlpha);
            Controls.Add(lbl_EstadoLineas);
            Controls.Add(lbl_ProgresoLineas);
            Controls.Add(lbl_Lineas);
            Controls.Add(pgb_TotalProgreso);
            Controls.Add(btn_CancelarEpsilon);
            Controls.Add(btn_CancelarDelta);
            Controls.Add(btn_CancelarBeta);
            Controls.Add(btn_CancelarGamma);
            Controls.Add(btn_CancelarAlpha);
            Controls.Add(btn_MenosLineas);
            Controls.Add(btn_MasLineas);
            Controls.Add(txt_NumeroLineas);
            Controls.Add(pgb_ProgresoEpsilon);
            Controls.Add(pgb_ProgresoDelta);
            Controls.Add(pgb_ProgresoBeta);
            Controls.Add(pgb_ProgresoGamma);
            Controls.Add(pgb_ProgresoAlpha);
            Controls.Add(lbl_Nombre);
            Controls.Add(btn_CancelarProduccion);
            Controls.Add(btn_IniciarProduccion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_IniciarProduccion;
        private Button btn_CancelarProduccion;
        private Label lbl_Nombre;
        private ProgressBar pgb_ProgresoAlpha;
        private ProgressBar pgb_ProgresoGamma;
        private ProgressBar pgb_ProgresoBeta;
        private ProgressBar pgb_ProgresoDelta;
        private ProgressBar pgb_ProgresoEpsilon;
        private TextBox txt_NumeroLineas;
        private Button btn_MasLineas;
        private Button btn_MenosLineas;
        private Button btn_CancelarAlpha;
        private Button btn_CancelarGamma;
        private Button btn_CancelarBeta;
        private Button btn_CancelarDelta;
        private Button btn_CancelarEpsilon;
        private ProgressBar pgb_TotalProgreso;
        private Label lbl_Lineas;
        private Label lbl_ProgresoLineas;
        private Label lbl_EstadoLineas;
        private Label lbl_LineaAlpha;
        private Label lbl_LineaBeta;
        private Label lbl_LineaGamma;
        private Label lbl_LineaDelta;
        private Label lbl_LineaEpsilon;
        private Label lbl_TotalProgreso;
        private Label lbl_Eventos;
        private Label lbl_EstadoEpsilon;
        private Label lbl_EstadoDelta;
        private Label lbl_EstadoGamma;
        private Label lbl_EstadoBeta;
        private Label lbl_EstadoAlpha;
        private Label lbl_PorcentajeTotal;
        private TextBox txt_EventoAlpha;
        private TextBox txt_EventoGamma;
        private TextBox txt_EventoBeta;
        private TextBox txt_EventoDelta;
        private TextBox txt_EventoEpsilon;
        private TextBox txt_EventoTotal;
        private TableLayoutPanel tlp_Lineas;
    }
}
