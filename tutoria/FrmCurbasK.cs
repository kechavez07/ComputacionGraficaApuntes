using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tutoria
{
    public partial class FrmCurbasK : Form
    {
        private const int CantidadPuntos = 40;

        public FrmCurbasK()
        {
            InitializeComponent();
            canva.Paint += Canvas_Paint;
        }

        private void FrmCurbasK_Load(object sender, EventArgs e)
        {
            canva.Invalidate();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen1 = new Pen(Color.Black, 1);  
            Pen pen2 = new Pen(Color.Blue, 1);    
            Pen pen3 = new Pen(Color.Red, 1);     
            Pen pen4 = new Pen(Color.Yellow, 1);  

            int ancho = canva.Width;
            int alto = canva.Height;

            for (int i = 0; i <= CantidadPuntos; i++)
            {
                int x = (ancho * i) / CantidadPuntos;
                int y = (alto * i) / CantidadPuntos;
                int xInv = (ancho * (CantidadPuntos - i)) / CantidadPuntos;
                int yInv = (alto * (CantidadPuntos - i)) / CantidadPuntos;

                g.DrawLine(pen1, 0, y, x, alto);

                g.DrawLine(pen2, x, 0, ancho, y);

                g.DrawLine(pen3, 0, yInv, x, 0);

                g.DrawLine(pen4, x, alto, ancho, yInv);

            }

        }
    }
}
