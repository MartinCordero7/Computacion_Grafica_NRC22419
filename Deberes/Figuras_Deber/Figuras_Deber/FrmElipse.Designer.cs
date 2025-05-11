namespace Figuras_Deber
{
    partial class FrmElipse
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
            txtEMenor = new TextBox();
            label4 = new Label();
            txtEMayor = new TextBox();
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
            grbProcesos.Location = new Point(12, 133);
            grbProcesos.Name = "grbProcesos";
            grbProcesos.Size = new Size(440, 69);
            grbProcesos.TabIndex = 4;
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
            grbSalidas.Location = new Point(12, 258);
            grbSalidas.Name = "grbSalidas";
            grbSalidas.Size = new Size(440, 125);
            grbSalidas.TabIndex = 3;
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
            grbEntradas.Controls.Add(txtEMenor);
            grbEntradas.Controls.Add(label4);
            grbEntradas.Controls.Add(txtEMayor);
            grbEntradas.Controls.Add(label1);
            grbEntradas.Location = new Point(12, 12);
            grbEntradas.Name = "grbEntradas";
            grbEntradas.Size = new Size(440, 97);
            grbEntradas.TabIndex = 2;
            grbEntradas.TabStop = false;
            grbEntradas.Text = "Entradas";
            // 
            // txtEMenor
            // 
            txtEMenor.Location = new Point(305, 53);
            txtEMenor.Name = "txtEMenor";
            txtEMenor.Size = new Size(98, 27);
            txtEMenor.TabIndex = 4;
            txtEMenor.KeyPress += txtEMenor_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 56);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Eje Menor";
            // 
            // txtEMayor
            // 
            txtEMayor.Location = new Point(97, 53);
            txtEMayor.Name = "txtEMayor";
            txtEMayor.Size = new Size(98, 27);
            txtEMayor.TabIndex = 2;
            txtEMayor.KeyPress += txtEMayor_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 53);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Eje Mayor";
            // 
            // FrmElipse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 439);
            Controls.Add(grbProcesos);
            Controls.Add(grbSalidas);
            Controls.Add(grbEntradas);
            Name = "FrmElipse";
            Text = "FrmElipse";
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
        private TextBox txtEMenor;
        private Label label4;
        private TextBox txtEMayor;
        private Label label1;
    }
}