using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            DrawTriangle();
        }
        public void DrawTriangle()
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            int x1, x2, x3, y1, y2, y3;
            x1 = 50;
            y1 = 50;
            x2 = 250;
            y2 = 50;
            x3 = 150;
            y3 = 150;

            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x2, y2, x3, y3);
            g.DrawLine(pen, x3, y3, x1, y1);
        }
    }
}
