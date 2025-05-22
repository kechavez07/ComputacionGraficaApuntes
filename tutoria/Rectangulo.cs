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
        public int rotationAngle;
        private const float SF = 20;
        private Pen mPen;
        public int X;
        public int Y;
        public Rectangulo()
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            rotationAngle = 0;
            X = 0; Y = 0;

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
        public void PlotShape(Graphics g)
        {
            g.TranslateTransform(200, 200);
            g.RotateTransform(rotationAngle);
            mPen = new Pen(Color.Blue, 3);
            g.DrawRectangle(mPen, -mWidth / 2, -mHeight / 2, mWidth, mHeight);
            g.ResetTransform();
        }

        public void CloseForm(Form ObjForm)
        { ObjForm.Close(); }
        
    }
}
