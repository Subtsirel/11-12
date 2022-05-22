using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;

namespace _11_12
{
    public partial class Form1 : Form
    {
        int k = 530;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Graphics g1 = e.Graphics;
            Graphics g2 = e.Graphics;
            Graphics g3 = e.Graphics;
            g.Clear(Color.Magenta);
            SolidBrush peg = new SolidBrush(Color.Brown);
            SolidBrush peg1 = new SolidBrush(Color.Black);
            SolidBrush peg2 = new SolidBrush(Color.Yellow);
            SolidBrush peg3 = new SolidBrush(Color.Khaki);
            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            GraphicsPath gp1 = new GraphicsPath(FillMode.Winding);
            GraphicsPath gp2 = new GraphicsPath(FillMode.Winding);
            GraphicsPath gp3 = new GraphicsPath(FillMode.Winding);
            gp.AddPolygon(new Point[] { new Point(450, k), new Point(465, k + 100), new Point(485,k + 100), new Point(500, k), new Point(475, k - 30), new Point(450, k) });
            gp1.AddPolygon(new Point[] { new Point(465, k + 100), new Point(445, k + 120), new Point(445, k + 90), new Point(460, k + 70), new Point(465, k + 100) });
            gp2.AddPolygon(new Point[] { new Point(485, k + 100), new Point(505, k + 120), new Point(505, k + 90), new Point(490, k + 70), new Point(485, k + 100) });
            gp3.AddEllipse(465, k + 5, 20, 20);
            g.FillPath(peg, gp);
            g1.FillPath(peg1, gp1);
            g2.FillPath(peg2, gp2);
            g3.FillPath(peg3, gp3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int H = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            k--;
            H++;
            Invalidate();
            textBox1.Text = H.ToString();
        }
    }
}