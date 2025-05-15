using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutoria
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void curbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCurbasK curba = new FrmCurbasK();
            curba.ShowDialog();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmROmbo frmROmbo = new FrmROmbo();
            frmROmbo.ShowDialog();
        }
    }
}
