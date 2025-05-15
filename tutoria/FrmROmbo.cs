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
    
    public partial class FrmROmbo : Form
    {
        private const int CantidadPuntos = 40;
        public FrmROmbo()
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
            Pen pen1 = new Pen(Color.Red, 1);     // Izquierda a derecha
            Pen pen2 = new Pen(Color.Blue, 1);    // Superior a inferior

            int ancho = canva.Width;
            int alto = canva.Height;

            for (int i = 0; i <= CantidadPuntos; i++)
            {
                int x = (ancho * i) / CantidadPuntos;
                int y = (alto * i) / CantidadPuntos;

                int xInv = (ancho * (CantidadPuntos - i)) / CantidadPuntos;
                int yInv = (alto * (CantidadPuntos - i)) / CantidadPuntos;

                g.DrawLine(pen1, 0, y, ancho, yInv);
                g.DrawLine(pen2, x, 0, xInv, alto);
            }

        }


    }
}
