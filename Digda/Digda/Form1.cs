﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digda
{
        public partial class Form1 : Form
        {
	public Form1()
	{
	        InitializeComponent();
	        timer1.Interval = 100;
	        timer1.Enabled = true;
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	        update();
	        draw();
	        
	}

	void update()
	{

	}

	void draw()
	{
	        //Bitmap screen = new Bitmap(700, 700);
	        //Graphics g = Graphics.FromImage(screen);

	        //Rectangle r = new Rectangle(0, 0, 100, 100);
	        //Bitmap b = Properties.Resources.test01;

	        //g.DrawImage(b, 0, 0);
	        //g.DrawImage(screen, 0, 0);

	        //g.Dispose();


	        Graphics g = this.CreateGraphics();
	        Bitmap b1 = Properties.Resources.test01;
	        b1 = new Bitmap(b1, 120, 800);
	        Rectangle r = new Rectangle(0, 0, 120, 300);
	        Bitmap b2 = b1.Clone(r, b1.PixelFormat);
	        g.DrawImage(b2, 0, 0);
	        g.Dispose();

	        //Graphics g = this.CreateGraphics();
	        //Bitmap b1 = Properties.Resources.test01;
	        //g.DrawImage(b1, 0, 0);
	        //g.Dispose();
	}

	private void Form1_Load(object sender, EventArgs e)
	{

	}
        }
}
