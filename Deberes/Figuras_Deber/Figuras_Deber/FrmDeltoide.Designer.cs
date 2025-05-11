namespace Figuras_Deber
{
    partial class FrmDeltoide
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
            txtLLargo = new TextBox();
            label6 = new Label();
            txtLCorto = new TextBox();
            label5 = new Label();
            txtDMenor = new TextBox();
            label4 = new Label();
            txtDMayor = new TextBox();
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
            grbProcesos.Location = new Point(12, 244);
            grbProcesos.Name = "grbProcesos";
            grbProcesos.Size = new Size(440, 69);
            grbProcesos.TabIndex = 7;
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
            grbSalidas.Location = new Point(12, 343);
            grbSalidas.Name = "grbSalidas";
            grbSalidas.Size = new Size(440, 125);
            grbSalidas.TabIndex = 6;
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
            grbEntradas.Controls.Add(txtLLargo);
            grbEntradas.Controls.Add(label6);
            grbEntradas.Controls.Add(txtLCorto);
            grbEntradas.Controls.Add(label5);
            grbEntradas.Controls.Add(txtDMenor);
            grbEntradas.Controls.Add(label4);
            grbEntradas.Controls.Add(txtDMayor);
            grbEntradas.Controls.Add(label1);
            grbEntradas.Location = new Point(12, 12);
            grbEntradas.Name = "grbEntradas";
            grbEntradas.Size = new Size(440, 205);
            grbEntradas.TabIndex = 5;
            grbEntradas.TabStop = false;
            grbEntradas.Text = "Entradas";
            // 
            // txtLLargo
            // 
            txtLLargo.Location = new Point(154, 157);
            txtLLargo.Name = "txtLLargo";
            txtLLargo.Size = new Size(191, 27);
            txtLLargo.TabIndex = 8;
            txtLLargo.KeyPress += txtLLargo_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 167);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 7;
            label6.Text = "Lado Largo";
            // 
            // txtLCorto
            // 
            txtLCorto.Location = new Point(154, 116);
            txtLCorto.Name = "txtLCorto";
            txtLCorto.Size = new Size(191, 27);
            txtLCorto.TabIndex = 6;
            txtLCorto.KeyPress += txtLCorto_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 126);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 5;
            label5.Text = "Lado Corto";
            // 
            // txtDMenor
            // 
            txtDMenor.Location = new Point(154, 83);
            txtDMenor.Name = "txtDMenor";
            txtDMenor.Size = new Size(191, 27);
            txtDMenor.TabIndex = 4;
            txtDMenor.KeyPress += txtDMenor_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 91);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 3;
            label4.Text = "Diagonal Menor";
            // 
            // txtDMayor
            // 
            txtDMayor.Location = new Point(154, 50);
            txtDMayor.Name = "txtDMayor";
            txtDMayor.Size = new Size(191, 27);
            txtDMayor.TabIndex = 2;
            txtDMayor.KeyPress += txtDMayor_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 53);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Diagonal Mayor";
            // 
            // FrmDeltoide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 497);
            Controls.Add(grbProcesos);
            Controls.Add(grbSalidas);
            Controls.Add(grbEntradas);
            Name = "FrmDeltoide";
            Text = "FrmDeltoide";
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
        private TextBox txtLLargo;
        private Label label6;
        private TextBox txtLCorto;
        private Label label5;
        private TextBox txtDMenor;
        private Label label4;
        private TextBox txtDMayor;
        private Label label1;
    }
}