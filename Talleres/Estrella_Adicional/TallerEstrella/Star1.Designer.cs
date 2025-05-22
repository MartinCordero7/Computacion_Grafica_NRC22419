namespace Figuras
{
    partial class frmStar1
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
            this.grbRotation = new System.Windows.Forms.GroupBox();
            this.btnCounterclockwise = new System.Windows.Forms.Button();
            this.btnClockwise = new System.Windows.Forms.Button();
            this.grbScale = new System.Windows.Forms.GroupBox();
            this.tbScale = new System.Windows.Forms.TrackBar();
            this.grbImagen = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbinputs = new System.Windows.Forms.GroupBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblRadius = new System.Windows.Forms.Label();
            this.grbMove = new System.Windows.Forms.GroupBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.grbRotation.SuspendLayout();
            this.grbScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScale)).BeginInit();
            this.grbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbinputs.SuspendLayout();
            this.grbMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRotation
            // 
            this.grbRotation.Controls.Add(this.btnCounterclockwise);
            this.grbRotation.Controls.Add(this.btnClockwise);
            this.grbRotation.Location = new System.Drawing.Point(33, 228);
            this.grbRotation.Name = "grbRotation";
            this.grbRotation.Size = new System.Drawing.Size(199, 62);
            this.grbRotation.TabIndex = 0;
            this.grbRotation.TabStop = false;
            this.grbRotation.Text = "Rotacion";
            // 
            // btnCounterclockwise
            // 
            this.btnCounterclockwise.Location = new System.Drawing.Point(99, 21);
            this.btnCounterclockwise.Name = "btnCounterclockwise";
            this.btnCounterclockwise.Size = new System.Drawing.Size(95, 23);
            this.btnCounterclockwise.TabIndex = 1;
            this.btnCounterclockwise.Text = "Antihorario";
            this.btnCounterclockwise.UseVisualStyleBackColor = true;
            this.btnCounterclockwise.Click += new System.EventHandler(this.btnCounterclockwise_Click);
            // 
            // btnClockwise
            // 
            this.btnClockwise.Location = new System.Drawing.Point(6, 21);
            this.btnClockwise.Name = "btnClockwise";
            this.btnClockwise.Size = new System.Drawing.Size(75, 23);
            this.btnClockwise.TabIndex = 0;
            this.btnClockwise.Text = "Horario";
            this.btnClockwise.UseVisualStyleBackColor = true;
            this.btnClockwise.Click += new System.EventHandler(this.btnClockwise_Click);
            // 
            // grbScale
            // 
            this.grbScale.Controls.Add(this.tbScale);
            this.grbScale.Location = new System.Drawing.Point(32, 296);
            this.grbScale.Name = "grbScale";
            this.grbScale.Size = new System.Drawing.Size(200, 75);
            this.grbScale.TabIndex = 1;
            this.grbScale.TabStop = false;
            this.grbScale.Text = "Escala";
            // 
            // tbScale
            // 
            this.tbScale.Location = new System.Drawing.Point(6, 21);
            this.tbScale.Maximum = 20;
            this.tbScale.Minimum = 1;
            this.tbScale.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbScale.Name = "tbScale";
            this.tbScale.Size = new System.Drawing.Size(188, 56);
            this.tbScale.TabIndex = 0;
            this.tbScale.Value = 10;
            this.tbScale.Scroll += new System.EventHandler(this.tbScale_Scroll);
            // 
            // grbImagen
            // 
            this.grbImagen.Controls.Add(this.picCanvas);
            this.grbImagen.Location = new System.Drawing.Point(266, 13);
            this.grbImagen.Name = "grbImagen";
            this.grbImagen.Size = new System.Drawing.Size(540, 379);
            this.grbImagen.TabIndex = 2;
            this.grbImagen.TabStop = false;
            this.grbImagen.Text = "Grafico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 22);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(518, 351);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbinputs
            // 
            this.grbinputs.Controls.Add(this.txtRadius);
            this.grbinputs.Controls.Add(this.btnDraw);
            this.grbinputs.Controls.Add(this.lblRadius);
            this.grbinputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbinputs.Location = new System.Drawing.Point(23, 11);
            this.grbinputs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbinputs.Name = "grbinputs";
            this.grbinputs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbinputs.Size = new System.Drawing.Size(222, 98);
            this.grbinputs.TabIndex = 3;
            this.grbinputs.TabStop = false;
            this.grbinputs.Text = "Entradas";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(106, 37);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 5;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(54, 71);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(92, 23);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(7, 37);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(57, 16);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radio: ";
            // 
            // grbMove
            // 
            this.grbMove.Controls.Add(this.btnRight);
            this.grbMove.Controls.Add(this.btnDown);
            this.grbMove.Controls.Add(this.btnUp);
            this.grbMove.Controls.Add(this.btnLeft);
            this.grbMove.Location = new System.Drawing.Point(33, 115);
            this.grbMove.Name = "grbMove";
            this.grbMove.Size = new System.Drawing.Size(212, 107);
            this.grbMove.TabIndex = 4;
            this.grbMove.TabStop = false;
            this.grbMove.Text = "Movimientos";
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(132, 66);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(42, 35);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(87, 66);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(39, 35);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(87, 21);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(41, 35);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(39, 66);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(42, 35);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // frmStar1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 404);
            this.Controls.Add(this.grbMove);
            this.Controls.Add(this.grbinputs);
            this.Controls.Add(this.grbImagen);
            this.Controls.Add(this.grbScale);
            this.Controls.Add(this.grbRotation);
            this.Name = "frmStar1";
            this.Text = "Estrella 1";
            this.Load += new System.EventHandler(this.frmStar1_Load);
            this.grbRotation.ResumeLayout(false);
            this.grbScale.ResumeLayout(false);
            this.grbScale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScale)).EndInit();
            this.grbImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbinputs.ResumeLayout(false);
            this.grbinputs.PerformLayout();
            this.grbMove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRotation;
        private System.Windows.Forms.Button btnCounterclockwise;
        private System.Windows.Forms.Button btnClockwise;
        private System.Windows.Forms.GroupBox grbScale;
        private System.Windows.Forms.TrackBar tbScale;
        private System.Windows.Forms.GroupBox grbImagen;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbinputs;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.GroupBox grbMove;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
    }
}