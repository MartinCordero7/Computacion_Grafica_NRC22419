namespace Proyecto1
{
    partial class Reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            picCanvas = new PictureBox();
            btnPlayPause = new Button();
            btnRetroceder = new Button();
            btnAvanzar = new Button();
            btnStop = new Button();
            progBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.LightSteelBlue;
            picCanvas.Location = new Point(12, 12);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1238, 564);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            // 
            // btnPlayPause
            // 
            btnPlayPause.BackgroundImage = (Image)resources.GetObject("btnPlayPause.BackgroundImage");
            btnPlayPause.Font = new Font("Segoe UI", 18F);
            btnPlayPause.Location = new Point(584, 597);
            btnPlayPause.Name = "btnPlayPause";
            btnPlayPause.Size = new Size(85, 50);
            btnPlayPause.TabIndex = 1;
            btnPlayPause.UseVisualStyleBackColor = true;
            btnPlayPause.Click += btnPlayPause_Click;
            // 
            // btnRetroceder
            // 
            btnRetroceder.BackgroundImage = (Image)resources.GetObject("btnRetroceder.BackgroundImage");
            btnRetroceder.Location = new Point(484, 608);
            btnRetroceder.Name = "btnRetroceder";
            btnRetroceder.Size = new Size(94, 35);
            btnRetroceder.TabIndex = 2;
            btnRetroceder.UseVisualStyleBackColor = true;
            btnRetroceder.Click += btnRetroceder_Click;
            // 
            // btnAvanzar
            // 
            btnAvanzar.Image = (Image)resources.GetObject("btnAvanzar.Image");
            btnAvanzar.Location = new Point(675, 608);
            btnAvanzar.Name = "btnAvanzar";
            btnAvanzar.Size = new Size(94, 35);
            btnAvanzar.TabIndex = 3;
            btnAvanzar.UseVisualStyleBackColor = true;
            btnAvanzar.Click += btnAvanzar_Click;
            // 
            // btnStop
            // 
            btnStop.BackgroundImage = (Image)resources.GetObject("btnStop.BackgroundImage");
            btnStop.Location = new Point(379, 603);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(52, 44);
            btnStop.TabIndex = 4;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // progBar
            // 
            progBar.Location = new Point(12, 572);
            progBar.Name = "progBar";
            progBar.Size = new Size(1238, 10);
            progBar.TabIndex = 5;
            // 
            // Reproductor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(1262, 673);
            Controls.Add(progBar);
            Controls.Add(btnStop);
            Controls.Add(btnAvanzar);
            Controls.Add(btnRetroceder);
            Controls.Add(btnPlayPause);
            Controls.Add(picCanvas);
            MaximizeBox = false;
            Name = "Reproductor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picCanvas;
        private Button btnPlayPause;
        private Button btnRetroceder;
        private Button btnAvanzar;
        private Button btnStop;
        private ProgressBar progBar;
    }
}