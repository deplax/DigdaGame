using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
        public partial class Form1 : Form
        {
	

	public Form1()
	{
	        InitializeComponent();
	        timer1.Interval = 100;
	        timer1.Enabled = true;
	        
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void Form1_Click(object sender, EventArgs e)
	{
	}

	public void print()
	{
	        Bitmap screen = new Bitmap(700, 700);
	        Graphics g = Graphics.FromImage(screen);

	        Bitmap b1 = Properties.Resources.test01;
	        g.DrawImage(b1, 0, 0);
	        g.Dispose(); 
	}

	void update()
	{

	}

	void draw()
	{
	        print();
	}

	private void timer1_Tick_1(object sender, EventArgs e)
	{
	        update();
	        draw();
	}
        }
}
