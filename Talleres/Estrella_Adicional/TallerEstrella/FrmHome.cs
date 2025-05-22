using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figuras;
using TallerEstrella;

namespace Vnetanas
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        private void estrellas1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStar1 frm2 = new frmStar1();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void estrellas2ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
    }
}
