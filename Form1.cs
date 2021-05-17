using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApplication
{
    public partial class PaintApplication : Form
    {

        /// <summary>
        /// If you need comments, the function names are not good enough.
        /// </summary>
        public PaintApplication()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(canvas.Width, canvas.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            canvas.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 25);
        int index;
        int x, y, sX, sY, cX, cY;

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }

                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }

            canvas.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }

            if (index == 4)
            {
                g.DrawLine(p, cX, cY, x, y);
            }

            if (index == 5)
            {
                List<Point> points = new List<Point>();

                points.Add(new Point(x, y));

                g.DrawPolygon(p, points.ToArray());
            }

            if (index == 6)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
        }

        private void pencilButton_click(object send, EventArgs e)
        {
            index = 1;
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void elipseButton_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void exitProgramTopMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u het programma afsluiten?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if(paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }

                if (index == 4)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }

                if (index == 5)
                {
                    Point[] pointArray =
                    {
                        new Point(0, 0),
                        new Point(50, 30),
                        new Point(30, 60)
                    };
                    
                    g.DrawPolygon(p, pointArray);
                }

                if (index == 6)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
            }    
        }

        private void loadFileTopMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informationTopMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void leftToolBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newTopMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
