namespace Algoritmos
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIGURASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoBresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoPuntoMedioCirculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorimtmoRellenoPorInundaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIGURASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIGURASToolStripMenuItem
            // 
            this.fIGURASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoDDAToolStripMenuItem,
            this.algoritmoBresenhamToolStripMenuItem,
            this.algoritmoPuntoMedioCirculoToolStripMenuItem,
            this.algorimtmoRellenoPorInundaciToolStripMenuItem});
            this.fIGURASToolStripMenuItem.Name = "fIGURASToolStripMenuItem";
            this.fIGURASToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.fIGURASToolStripMenuItem.Text = "ALGORITMOS";
            this.fIGURASToolStripMenuItem.Click += new System.EventHandler(this.fIGURASToolStripMenuItem_Click);
            // 
            // algoritmoDDAToolStripMenuItem
            // 
            this.algoritmoDDAToolStripMenuItem.Name = "algoritmoDDAToolStripMenuItem";
            this.algoritmoDDAToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.algoritmoDDAToolStripMenuItem.Text = "Algoritmo DDA";
            this.algoritmoDDAToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDDAToolStripMenuItem_Click);
            // 
            // algoritmoBresenhamToolStripMenuItem
            // 
            this.algoritmoBresenhamToolStripMenuItem.Name = "algoritmoBresenhamToolStripMenuItem";
            this.algoritmoBresenhamToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.algoritmoBresenhamToolStripMenuItem.Text = "Algoritmo Bresenham";
            this.algoritmoBresenhamToolStripMenuItem.Click += new System.EventHandler(this.algoritmoBresenhamToolStripMenuItem_Click);
            // 
            // algoritmoPuntoMedioCirculoToolStripMenuItem
            // 
            this.algoritmoPuntoMedioCirculoToolStripMenuItem.Name = "algoritmoPuntoMedioCirculoToolStripMenuItem";
            this.algoritmoPuntoMedioCirculoToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.algoritmoPuntoMedioCirculoToolStripMenuItem.Text = "Algoritmo Punto Medio Circulo";
            this.algoritmoPuntoMedioCirculoToolStripMenuItem.Click += new System.EventHandler(this.algoritmoPuntoMedioCirculoToolStripMenuItem_Click);
            // 
            // algorimtmoRellenoPorInundaciToolStripMenuItem
            // 
            this.algorimtmoRellenoPorInundaciToolStripMenuItem.Name = "algorimtmoRellenoPorInundaciToolStripMenuItem";
            this.algorimtmoRellenoPorInundaciToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.algorimtmoRellenoPorInundaciToolStripMenuItem.Text = "Algorimtmo Relleno por Inundación";
            this.algorimtmoRellenoPorInundaciToolStripMenuItem.Click += new System.EventHandler(this.algorimtmoRellenoPorInundaciToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIGURASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoBresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoPuntoMedioCirculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorimtmoRellenoPorInundaciToolStripMenuItem;
    }
}