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
    public partial class FrmRomboC : Form
    {
        private int n = 10;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            int padding = 80;
            
            int size = this.ClientSize.Width - 2 * padding;
            int middleS = this.ClientSize.Width/2;
            Point topLeft = new Point(padding, padding);
            Point topRight = new Point(padding + size, padding);
            Point bottomLeft = new Point(padding, padding + size);
            Point bottomRight = new Point(padding + size, padding + size);
            Point middle = new Point(middleS, middleS);
            Pen redPen = new Pen(Color.Red, 1);
            Pen orangePen = new Pen(Color.Orange, 1);
            Pen bluePen = new Pen(Color.Blue, 1);
            Pen blackPen = new Pen(Color.Black, 1);


            for (int i = 0; i <= n; i++)
            {
                float t = (float)i / n;
                Point p1 = Lerp(topRight, middle, t);
                Point p2 = Lerp(middle, bottomRight, t);
                g.DrawLine(redPen, p1, p2);
            }


            for (int i = 0; i <= n; i++)
            {
                float t = (float)i / n;
                Point p1 = Lerp(topLeft, middle, t);
                Point p2 = Lerp(middle, bottomLeft, t);
                g.DrawLine(orangePen, p1, p2);
            }


            for (int i = 0; i <= n; i++)
            {
                float t = (float)i / n;
                Point p1 = Lerp(topLeft, middle, t);
                Point p2 = Lerp(middle,topRight, t);
                g.DrawLine(bluePen, p1, p2);
            }


            for (int i = 0; i <= n; i++)
            {
                float t = (float)i / n;
                Point p1 = Lerp(bottomLeft, middle, t);
                Point p2 = Lerp(middle,bottomRight, t);
                g.DrawLine(blackPen, p1, p2);
            }

        }
        private Point Lerp(Point a, Point b, float t)
        {
            int x = (int)(a.X + (b.X - a.X) * t);
            int y = (int)(a.Y + (b.Y - a.Y) * t);
            return new Point(x, y);
        }
        public FrmRomboC()
        {
            InitializeComponent();
        }

        private void FrmRomboC_Load(object sender, EventArgs e)
        {

        }
    }
}
