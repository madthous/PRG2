using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPaint
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 4);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X; y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void knedlikPen_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
            pen.Width = 4;
        }

        private void knedlikDel_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            pen.Width = 25;
        }
    }
}
