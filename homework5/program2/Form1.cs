using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(graphics == null)
            {
                graphics = this.CreateGraphics();
            }
            drawCayleyTree(10, 300, 400,100, -Math.PI / 2);
            button1.Enabled = false;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReScree();
            button1.Enabled = true;
        }


        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Random rnd = new Random();
        double rand()
        {
            return rnd.NextDouble();
        }


        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1,n/2);

            drawCayleyTree(n - 1, x1, y1, per1 * leng*(0.5 + rand()), th + th1 * (0.5 + rand()));
            drawCayleyTree(n - 1, x1, y1, per2 * leng*(0.4 + rand()), th - th2 * (0.5 + rand()));
        }
        void drawLine(double x0,double y0,double x1,double y1,int width)
        {
            graphics.DrawLine(
           new Pen(Color.Red,width),
            (int)x0,(int)y0,(int)x1,(int)y1);
        }

        private void ReScree()
        {
            this.Invalidate();//使窗口重绘
        }
    }
}
