using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
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

        public  MovingShape(Control app)
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
            }
        }
    }
}
