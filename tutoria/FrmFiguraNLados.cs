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
    public partial class FrmFiguraNLados : Form
    {
        private Rectangulo objRectangulo = new Rectangulo();

        public FrmFiguraNLados()
        {
            InitializeComponent();
        }

        private void FrmFiguraNLados_Load(object sender, EventArgs e)
        {

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
           objRectangulo.ReadData(txtRadio, txtLados);
        }
    }
}
