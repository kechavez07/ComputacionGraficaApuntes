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
    public partial class FrmCurvas : Form
    {
        private int n = 50;
        public FrmCurvas()
        {

            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            int padding = 80;
            int size = this.ClientSize.Width - 2 * padding;

            Point topLeft = new Point(padding, padding);
            Point topRight = new Point(padding + size, padding);
            Point bottomLeft = new Point(padding, padding + size);
            Point bottomRight = new Point(padding + size, padding + size);

            Pen redPen = new Pen(Color.Red, 1);
            Pen orangePen = new Pen(Color.Orange, 1);
            Pen bluePen = new Pen(Color.Blue, 1);
            Pen blackPen = new Pen(Color.Black, 1);


            for (int i = 0; i <= n; i++)
            {
                float t = (float)i / n;
                Point p1 = Lerp(topLeft, bottomLeft, t);
                Point p2 = Lerp(bottomLeft, bottomRight, t);
                g.DrawLine(redPen, p1, p2);
            }


            for (int i = 0; i <= n; i++)
            {
                float t = (float)i / n;
                Point p1 = Lerp(bottomLeft, bottomRight, t);
                Point p2 = Lerp(bottomRight, topRight, t);
                g.DrawLine(orangePen, p1, p2);
            }


            for (int i = 0; i <= n; i++)
            {
                float t = (float)i / n;
                Point p1 = Lerp(bottomRight, topRight, t);
                Point p2 = Lerp(topRight, topLeft, t);
                g.DrawLine(bluePen, p1, p2);
            }


            for (int i = 0; i <= n; i++)
            {
                float t = (float)i / n;
                Point p1 = Lerp(topRight, topLeft, t);
                Point p2 = Lerp(topLeft, bottomLeft, t);
                g.DrawLine(blackPen, p1, p2);
            }

        }
        private Point Lerp(Point a, Point b, float t)
        {
            int x = (int)(a.X + (b.X - a.X) * t);
            int y = (int)(a.Y + (b.Y - a.Y) * t);
            return new Point(x, y);
        }

        private void pictureBox1_Click(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void canvaCuadrado_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCurvas_Load(object sender, EventArgs e)
        {

        }
    }
}
