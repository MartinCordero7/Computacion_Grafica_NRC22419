namespace TallerEstrella
{
    partial class FrmEstrella
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbSalidas = new GroupBox();
            picCanvas = new PictureBox();
            grbProcesos = new GroupBox();
            btnRotarIz = new Button();
            btnRotarDer = new Button();
            btnArriba = new Button();
            btnAbajo = new Button();
            btnIzquierda = new Button();
            btnDerecha = new Button();
            label3 = new Label();
            trBar = new TrackBar();
            btnReset = new Button();
            btnBorrar = new Button();
            btnCalcular = new Button();
            label2 = new Label();
            grbEntradas = new GroupBox();
            txtRadio = new TextBox();
            label1 = new Label();
            grbSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            grbProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trBar).BeginInit();
            grbEntradas.SuspendLayout();
            SuspendLayout();
            // 
            // grbSalidas
            // 
            grbSalidas.Controls.Add(picCanvas);
            grbSalidas.Location = new Point(414, 29);
            grbSalidas.Name = "grbSalidas";
            grbSalidas.Size = new Size(502, 548);
            grbSalidas.TabIndex = 6;
            grbSalidas.TabStop = false;
            grbSalidas.Text = "Salidas";
            // 
            // picCanvas
            // 
            picCanvas.Location = new Point(6, 26);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(490, 493);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            // 
            // grbProcesos
            // 
            grbProcesos.Controls.Add(btnRotarIz);
            grbProcesos.Controls.Add(btnRotarDer);
            grbProcesos.Controls.Add(btnArriba);
            grbProcesos.Controls.Add(btnAbajo);
            grbProcesos.Controls.Add(btnIzquierda);
            grbProcesos.Controls.Add(btnDerecha);
            grbProcesos.Controls.Add(label3);
            grbProcesos.Controls.Add(trBar);
            grbProcesos.Controls.Add(btnReset);
            grbProcesos.Controls.Add(btnBorrar);
            grbProcesos.Controls.Add(btnCalcular);
            grbProcesos.Controls.Add(label2);
            grbProcesos.Location = new Point(0, 163);
            grbProcesos.Name = "grbProcesos";
            grbProcesos.Size = new Size(395, 414);
            grbProcesos.TabIndex = 5;
            grbProcesos.TabStop = false;
            grbProcesos.Text = "Procesos";
            // 
            // btnRotarIz
            // 
            btnRotarIz.Location = new Point(23, 273);
            btnRotarIz.Name = "btnRotarIz";
            btnRotarIz.Size = new Size(94, 29);
            btnRotarIz.TabIndex = 12;
            btnRotarIz.Text = "<--";
            btnRotarIz.UseVisualStyleBackColor = true;
            // 
            // btnRotarDer
            // 
            btnRotarDer.Location = new Point(265, 273);
            btnRotarDer.Name = "btnRotarDer";
            btnRotarDer.Size = new Size(94, 29);
            btnRotarDer.TabIndex = 11;
            btnRotarDer.Text = "-->";
            btnRotarDer.UseVisualStyleBackColor = true;
            // 
            // btnArriba
            // 
            btnArriba.Location = new Point(138, 262);
            btnArriba.Name = "btnArriba";
            btnArriba.Size = new Size(94, 29);
            btnArriba.TabIndex = 10;
            btnArriba.Text = "▲";
            btnArriba.UseVisualStyleBackColor = true;
            btnArriba.Click += btnArriba_Click;
            // 
            // btnAbajo
            // 
            btnAbajo.Location = new Point(138, 319);
            btnAbajo.Name = "btnAbajo";
            btnAbajo.Size = new Size(94, 29);
            btnAbajo.TabIndex = 9;
            btnAbajo.Text = "▼";
            btnAbajo.UseVisualStyleBackColor = true;
            btnAbajo.Click += btnAbajo_Click;
            // 
            // btnIzquierda
            // 
            btnIzquierda.Location = new Point(23, 319);
            btnIzquierda.Name = "btnIzquierda";
            btnIzquierda.Size = new Size(94, 29);
            btnIzquierda.TabIndex = 8;
            btnIzquierda.Text = "◄";
            btnIzquierda.UseVisualStyleBackColor = true;
            btnIzquierda.Click += btnIzquierda_Click;
            // 
            // btnDerecha
            // 
            btnDerecha.Location = new Point(265, 319);
            btnDerecha.Name = "btnDerecha";
            btnDerecha.Size = new Size(94, 29);
            btnDerecha.TabIndex = 7;
            btnDerecha.Text = "►";
            btnDerecha.UseVisualStyleBackColor = true;
            btnDerecha.Click += btnDerecha_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 114);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Escala";
            // 
            // trBar
            // 
            trBar.Location = new Point(48, 171);
            trBar.Name = "trBar";
            trBar.Size = new Size(298, 56);
            trBar.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(276, 56);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(148, 56);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Limpiar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(20, 56);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 230);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Movimientos";
            // 
            // grbEntradas
            // 
            grbEntradas.Controls.Add(txtRadio);
            grbEntradas.Controls.Add(label1);
            grbEntradas.Location = new Point(0, 29);
            grbEntradas.Name = "grbEntradas";
            grbEntradas.Size = new Size(395, 112);
            grbEntradas.TabIndex = 4;
            grbEntradas.TabStop = false;
            grbEntradas.Text = "Entradas";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(89, 58);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(143, 27);
            txtRadio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 58);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Radio";
            // 
            // FrmEstrella
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 568);
            Controls.Add(grbSalidas);
            Controls.Add(grbProcesos);
            Controls.Add(grbEntradas);
            Name = "FrmEstrella";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEstrella";
            grbSalidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            grbProcesos.ResumeLayout(false);
            grbProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trBar).EndInit();
            grbEntradas.ResumeLayout(false);
            grbEntradas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSalidas;
        private PictureBox picCanvas;
        private GroupBox grbProcesos;
        private Button btnArriba;
        private Button btnAbajo;
        private Button btnIzquierda;
        private Button btnDerecha;
        private Label label3;
        private TrackBar trBar;
        private Button btnReset;
        private Button btnBorrar;
        private Button btnCalcular;
        private Label label2;
        private GroupBox grbEntradas;
        private TextBox txtRadio;
        private Label label1;
        private Button btnRotarIz;
        private Button btnRotarDer;
    }
}