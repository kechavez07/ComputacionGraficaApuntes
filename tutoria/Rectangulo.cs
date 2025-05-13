using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutoria
{
    internal class Rectangulo
    {
        private float mWidth;
        private float mHeight;
        private float mPerimeter;
        private float mArea; 
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Rectangulo()
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

        }
        public void ReadData(TextBox txtWidth, TextBox txtHeight)
        {
            try
            {
                mWidth = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeight.Text);

            }
            catch
            {
                MessageBox.Show("Ingreso no válido...",
                                "Mensaje de error");
            }

        }

        public void PerimetroRectangulo()
        {
            mPerimeter = 2 * mWidth + 2 * mHeight;

        }
        public void AreaRectangulo()
        {
            mArea=mWidth*mHeight;
        }
        
        public void ImprimirData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void InicializarData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mWidth = 0.0f; mHeight=0.0f;
            mPerimeter=0.0f; mArea=0.0f;
            txtWidth.Text = ""; txtHeight.Text = "";
            txtPerimeter.Text = "";txtArea.Text = "";
            txtWidth.Focus();
            picCanvas.Refresh();
        }
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph=picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);
        }
        public void CloseForm(Form ObjForm)
        { ObjForm.Close(); }
    }
}
