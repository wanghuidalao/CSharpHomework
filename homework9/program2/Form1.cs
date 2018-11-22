using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        int n = 0;
        public Form1()
        {
            //this.Show();
            //AddMovingObject();
            InitializeComponent();
        }
        private List<MovingShape> shapes = new List<MovingShape>();
        //private List<Thread> threads = new List<Thread>();
        //Stopwatch watch = new Stopwatch();

        void AddMovingObject()
        {
            
            MovingShape obj = new MovingShape(this.pictureBox2);
            shapes.Add(obj);
            n++;
            MessageBox.Show("当前任务数为"+ n);
            //Thread thread = new Thread(obj.Run);
            //thread.IsBackground = true;
            //thread.Start();
            //threads.Add(thread);
            //Parallel.ForEach(shapes, n => { n.Run(); });
            //var a = from n in threads.AsParallel()
            //        where n.ThreadState != System.Threading.ThreadState.Running
            //        select n;
            //MessageBox.Show(a.First().ToString());
            //foreach (var m in a)
            //{
                
            //}
            //shapes.Add(obj);
            //ParallelLoopResult loopResult = Parallel.ForEach(
            //    shapes,  (MovingShape shape,ParallelLoopState state )=>
            //     {
            //         state.Break();
            //         shape.Run();
            //     });
        }

        void RemoveMovingObject ()
        {
            //if (threads.Count == 0) { return; }
            if (shapes.Count == 0) { return ; }
            shapes[0].Stop();
            //threads[0].Abort();
            shapes.RemoveAt(0);
            //threads.RemoveAt(0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            AddMovingObject();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //watch.Start();
            AddMovingObject();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
              Parallel.ForEach(shapes, n => { n.Run(); });
             
            //watch.Stop();
            //MessageBox.Show(watch.ElapsedMilliseconds.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RemoveMovingObject();
        }
        class MovingShape
        {
            bool bContinue = false;
            private int size = 60;
            private int speed = 10;
            private Color color;
            private Brush brush;
            private Pen pen;
            private int type;
            private int x, y, w, h, dx, dy;
            protected Control app;
            Random rnd = new Random();

            public MovingShape(Control app)
            {
                this.app = app;
                x = rnd.Next(app.Width);
                y = rnd.Next(app.Height);
                w = rnd.Next(10, size);
                h = rnd.Next(10, size);
                dx = rnd.Next(5, speed);
                dy = rnd.Next(5, speed);
                color = Color.FromArgb(
                    rnd.Next(128, 256),
                    rnd.Next(128, 256),
                    rnd.Next(128, 256));
                brush = new SolidBrush(color);
                pen = new Pen(new SolidBrush(Color.Black), 1);
                type = rnd.Next(3);
                bContinue = true;
            }

            public void Run()
            {
                while (bContinue)
                {
                    x += dx;
                    y += dy;
                    if (x < 0 || x + w > app.Width) { dx = -dx; }
                    if (y < 0 || y + h < app.Height) { dy = -dy; }
                    Graphics g = app.CreateGraphics();

                    switch (type)
                    {
                        case 0:
                            g.FillRectangle(brush, x, y, w, h);
                            g.DrawRectangle(pen, x, y, w, h);
                            break;
                        case 1:
                            g.FillEllipse(brush, x, y, w, h);
                            g.DrawEllipse(pen, x, y, w, h);
                            break;
                        case 2:
                            g.FillPie(brush, x, y, w, h, 0.1F, 0.9F);
                            g.DrawArc(pen, x, y, w, h, 0.1F, 0.9F);
                            break;
                    }
                    Thread.Sleep(130);
                }
            }
            public void Stop()
            {
                bContinue = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

 
    }
}
