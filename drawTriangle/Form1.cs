﻿using System;
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
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black);
            int triX1 = 50;
            int triX2 = 100;
            int triX3 = 75;
            int triY1 = 50;
            int triY2 = 50;
            int triY3 = 75;
            DrawTriangle(drawPen,triX1,triY1,triX2,triY2,triX3,triY3);
        }
        public void DrawTriangle(Pen pen,int x1,int y1,int x2,int y2,int x3, int y3)
        {
            Graphics g = this.CreateGraphics();            

            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x2, y2, x3, y3);
            g.DrawLine(pen, x3, y3, x1, y1);
        }
    }
}
