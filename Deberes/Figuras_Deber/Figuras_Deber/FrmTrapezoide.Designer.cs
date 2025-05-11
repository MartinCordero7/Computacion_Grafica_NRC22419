namespace Figuras_Deber
{
    partial class FrmTrapezoide
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
            grbProcesos = new GroupBox();
            btnResetear = new Button();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            grbSalidas = new GroupBox();
            txtArea = new TextBox();
            txtPerimetro = new TextBox();
            label2 = new Label();
            label3 = new Label();
            grbEntradas = new GroupBox();
            txtLado3 = new TextBox();
            label7 = new Label();
            txtLado4 = new TextBox();
            label5 = new Label();
            txtLado2 = new TextBox();
            label4 = new Label();
            txtLado1 = new TextBox();
            label1 = new Label();
            grbProcesos.SuspendLayout();
            grbSalidas.SuspendLayout();
            grbEntradas.SuspendLayout();
            SuspendLayout();
            // 
            // grbProcesos
            // 
            grbProcesos.BackColor = SystemColors.GradientInactiveCaption;
            grbProcesos.Controls.Add(btnResetear);
            grbProcesos.Controls.Add(btnLimpiar);
            grbProcesos.Controls.Add(btnCalcular);
            grbProcesos.Location = new Point(12, 194);
            grbProcesos.Name = "grbProcesos";
            grbProcesos.Size = new Size(440, 69);
            grbProcesos.TabIndex = 16;
            grbProcesos.TabStop = false;
            grbProcesos.Text = "Procesos";
            // 
            // btnResetear
            // 
            btnResetear.Location = new Point(330, 34);
            btnResetear.Name = "btnResetear";
            btnResetear.Size = new Size(94, 29);
            btnResetear.TabIndex = 2;
            btnResetear.Text = "Resetear";
            btnResetear.UseVisualStyleBackColor = true;
            btnResetear.Click += btnResetear_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(164, 34);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(18, 34);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // grbSalidas
            // 
            grbSalidas.BackColor = SystemColors.GradientInactiveCaption;
            grbSalidas.Controls.Add(txtArea);
            grbSalidas.Controls.Add(txtPerimetro);
            grbSalidas.Controls.Add(label2);
            grbSalidas.Controls.Add(label3);
            grbSalidas.Location = new Point(12, 297);
            grbSalidas.Name = "grbSalidas";
            grbSalidas.Size = new Size(440, 125);
            grbSalidas.TabIndex = 15;
            grbSalidas.TabStop = false;
            grbSalidas.Text = "Salidas";
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new Point(97, 34);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(191, 27);
            txtArea.TabIndex = 3;
            // 
            // txtPerimetro
            // 
            txtPerimetro.Enabled = false;
            txtPerimetro.Location = new Point(97, 77);
            txtPerimetro.Name = "txtPerimetro";
            txtPerimetro.Size = new Size(191, 27);
            txtPerimetro.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 34);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 2;
            label2.Text = "Area";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 80);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Perimetro";
            // 
            // grbEntradas
            // 
            grbEntradas.BackColor = SystemColors.GradientInactiveCaption;
            grbEntradas.Controls.Add(txtLado3);
            grbEntradas.Controls.Add(label7);
            grbEntradas.Controls.Add(txtLado4);
            grbEntradas.Controls.Add(label5);
            grbEntradas.Controls.Add(txtLado2);
            grbEntradas.Controls.Add(label4);
            grbEntradas.Controls.Add(txtLado1);
            grbEntradas.Controls.Add(label1);
            grbEntradas.Location = new Point(12, 12);
            grbEntradas.Name = "grbEntradas";
            grbEntradas.Size = new Size(440, 165);
            grbEntradas.TabIndex = 14;
            grbEntradas.TabStop = false;
            grbEntradas.Text = "Entradas";
            // 
            // txtLado3
            // 
            txtLado3.Location = new Point(294, 50);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(111, 27);
            txtLado3.TabIndex = 10;
            txtLado3.KeyPress += txtLado3_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 50);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 9;
            label7.Text = "Lado 3";
            // 
            // txtLado4
            // 
            txtLado4.Location = new Point(294, 89);
            txtLado4.Name = "txtLado4";
            txtLado4.Size = new Size(111, 27);
            txtLado4.TabIndex = 6;
            txtLado4.KeyPress += txtLado4_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 92);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 5;
            label5.Text = "Lado 4";
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(97, 89);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(111, 27);
            txtLado2.TabIndex = 4;
            txtLado2.KeyPress += txtLado2_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 92);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Lado 2";
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(97, 50);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(107, 27);
            txtLado1.TabIndex = 2;
            txtLado1.KeyPress += txtLado1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 53);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "Lado 1";
            // 
            // FrmTrapezoide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 450);
            Controls.Add(grbProcesos);
            Controls.Add(grbSalidas);
            Controls.Add(grbEntradas);
            Name = "FrmTrapezoide";
            Text = "FrmTrapezoide";
            grbProcesos.ResumeLayout(false);
            grbSalidas.ResumeLayout(false);
            grbSalidas.PerformLayout();
            grbEntradas.ResumeLayout(false);
            grbEntradas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbProcesos;
        private Button btnResetear;
        private Button btnLimpiar;
        private Button btnCalcular;
        private GroupBox grbSalidas;
        private TextBox txtArea;
        private TextBox txtPerimetro;
        private Label label2;
        private Label label3;
        private GroupBox grbEntradas;
        private TextBox txtLado3;
        private Label label7;
        private TextBox txtLado4;
        private Label label5;
        private TextBox txtLado2;
        private Label label4;
        private TextBox txtLado1;
        private Label label1;
    }
}