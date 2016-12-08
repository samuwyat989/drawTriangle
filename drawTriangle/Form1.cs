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
            Pen pen = new Pen(Color.Black);
            int x1, x2, x3, y1, y2, y3;
            x1 = 100;
            y1 = 100;
            x2 = 300;
            y2 = 100;
            x3 = 200;
            y3 = 200;
        }
    }
}
