using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestralka_Macrohard_Draw
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(platno.Width,platno.Height);
            g = Graphics.FromImage(bm);
            platno.Image = bm;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 4);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }
        Bitmap bm;
        Graphics g;
        bool kreslime = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 4);
        Pen zmiz = new Pen(Color.White, 25);
        int n = 0;
        int x, y, sX, sY, cX, cY;
        ColorDialog coldia = new ColorDialog();
        Color clr;

        private void knedlikRect_Click(object sender, EventArgs e)
        {
            n = 4;
        }

        private void knedlikLine_Click(object sender, EventArgs e)
        {
            n = 5;
        }

        private void platno_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (kreslime)
            {
                switch (n)
                {
                    case 3:
                        g.DrawEllipse(pen, cX, cY, sX, sY);
                        break;
                    case 4:
                        g.DrawRectangle(pen, cX, cY, sX, sY);
                        break;
                    case 5:
                        g.DrawLine(pen, cX, cY, x, y);
                        break;
                    default:
                        break;

                }
            }
        }

        private void knedlikSmaz_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            platno.Image = bm;
            n = 0;
        }

        private void kneldikVyber_Click(object sender, EventArgs e)
        {
            n = 0;
            coldia.ShowDialog();
            clr = coldia.Color;
            panelUkaz.BackColor = clr;
            pen.Color = clr;
        }

        private void knedlikElipsa_Click(object sender, EventArgs e)
        {
            n = 3;
        }

        private void platno_MouseDown(object sender, MouseEventArgs e)
        {
            kreslime = true;
            py = e.Location;
            cX = e.X; cY = e.Y;
        }

        private void platno_MouseClick(object sender, MouseEventArgs e)
        {
            if (n == 7)
            {
                Point point = bodik(platno, e.Location);
                Fill(bm, point.X,point.Y, clr);
            }
        }

        private void knedlikVypln_Click(object sender, EventArgs e)
        {
            n = 7;
        }

        private void platno_MouseMove(object sender, MouseEventArgs e)
        {
            if (kreslime)
            {
                switch (n)
                {
                    case 1:
                        px = e.Location;
                        g.DrawLine(pen, px, py);
                        py = px;
                        break;
                    case 2:
                        px = e.Location;
                        g.DrawLine(zmiz, px, py);
                        py = px;
                        break;
                    default:
                        break;
                }
            }
            platno.Refresh();

            x = e.X; y = e.Y;
            sX = e.X - cX; sY = e.Y - cY;
        }

        private void knedlikUloz_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, platno.Width, platno.Height),bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
            //z neznámého důvodu ukládá černé pozadí
            MessageBox.Show("Úspěšně sis uložil výtvor, kongratulace");
        }

        private void knedlikPen_Click(object sender, EventArgs e)
        {
            n = 1;
        }

        private void knedlikVymaz_Click(object sender, EventArgs e)
        {
            n = 2;
        }

        private void platno_MouseUp(object sender, MouseEventArgs e)
        {
            kreslime = false;
            sX = x - cX; sY = y - cY;
            switch (n)
            {
                case 3:
                    g.DrawEllipse(pen, cX, cY, sX, sY); 
                    break;
                case 4:
                    g.DrawRectangle(pen,cX, cY, sX, sY);
                    break;
                case 5:
                    g.DrawLine(pen, cX, cY, x, y);
                    break;
                default:
                    break;
            
            }
        }
        
        static Point bodik(PictureBox pb, Point pnt)
        {
            float pX = 1f*pb.Image.Width / pb.Width;
            float pY = 1f*pb.Image.Height / pb.Height;
            return new Point((int)(pnt.X*pX), (int)(pnt.Y*pY));
        }
        private void plnenipomoc(Bitmap bm, Stack<Point>sp,int x, int y,Color wascol, Color willcol)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == wascol)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, willcol);
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color nuebarva)
        { 
            Color wascol = bm.GetPixel(x, y);
            Stack<Point> bob = new Stack<Point>();
            bob.Push(new Point(x, y));
            bm.SetPixel(x, y, nuebarva);
            if (wascol == nuebarva)
            {
                return;
            }
            while (bob.Count>0)
            {
                Point poi = (Point)bob.Pop();
                if (poi.X>0 && poi.Y>0 && poi.X<bm.Width-1 && poi.Y<bm.Height-1)
                {
                    plnenipomoc(bm, bob, poi.X - 1, poi.Y, wascol, nuebarva);
                    plnenipomoc(bm, bob, poi.X, poi.Y - 1, wascol, nuebarva);
                    plnenipomoc(bm, bob, poi.X + 1, poi.Y, wascol, nuebarva);
                    plnenipomoc(bm, bob, poi.X, poi.Y + 1, wascol, nuebarva);

                }
            }
        }
    }
}
