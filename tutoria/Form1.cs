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
    public partial class Form1 : Form
    {
        

        private Rectangulo objRectangulo=new Rectangulo();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objRectangulo.InicializarData(txtAncho, txtLargo, txtPerim, txtArea, canvas);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            objRectangulo.ReadData(txtAncho, txtLargo);
            objRectangulo.PerimetroRectangulo();
            objRectangulo.AreaRectangulo();
            objRectangulo.ImprimirData(txtPerim,txtArea);
            objRectangulo.rotationAngle = int.Parse(txtRotationAngle.Text);
            canvas.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objRectangulo.InicializarData(txtAncho, txtLargo, txtPerim, txtArea, canvas);
        }

        private void tnSalir_Click(object sender, EventArgs e)
        {
            objRectangulo.CloseForm(this);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            objRectangulo.rotationAngle = e.NewValue;
            txtRotationAngle.Text = objRectangulo.rotationAngle.ToString();
            
            canvas.Invalidate();
        }

        private void canvas_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
           
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            objRectangulo.PlotShape(e.Graphics);
        }
    }
}
