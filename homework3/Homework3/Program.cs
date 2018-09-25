using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    interface IChart
    {
        void display();
    }
    class Triangle:IChart
    {
        double  bottom, height ,area;
        public Triangle()
        {
            Console.Write("高：");
            this.height =double .Parse(Console.ReadLine());
            Console.Write("底长：");
            this.bottom = double.Parse(Console.ReadLine());
            this.area = bottom * height / 2;
        }
        public void display()
        {
            Console.WriteLine("三角形的面积是：" + this.area);
        }

    }
    class Circular:IChart
    {
        double radius, area;
        public Circular()
        {
            Console.WriteLine("半径：");
            this.radius = double.Parse(Console.ReadLine());
            this.area = 3.14 * radius * radius;
        }
        public void display()
        {
            Console.WriteLine("圆形的面积为：" + this.area);
        }
    }
    class Rectangle:IChart
    {
        double length, width, area;
        public Rectangle()
        {
            Console.WriteLine("长：");
            this.length = double.Parse(Console.ReadLine());
            Console.WriteLine("宽：");
            this.width = double.Parse(Console.ReadLine());
            this.area = length * width;
        }
        public void display()
        {
            Console.WriteLine("矩形的面积为：" + this.area);
        }
    }
    class Square:IChart
    {
        double length, area;
        public Square()
        {
            Console.WriteLine("边长：");
            this.length = double.Parse(Console.ReadLine());
            this.area = length * length;
        }
        public void display()
        {
            Console.WriteLine("正方形的面积为：" + this.area);
        }
    }
    class ChartFactory
    {
        public static IChart GetChart(string figure)
        {
            IChart chart = null;
            if (figure.Equals("Triangle"))
            {
                chart = new Triangle();
            }
            else if (figure.Equals("Circular"))
            {
                chart = new Circular();
            }
            else if (figure.Equals("Rectangle"))
            {
                chart = new Rectangle();
            }
            else if (figure.Equals("Square"))
            {
                chart = new Square();
            }
            else
            {
                Console.WriteLine("暂无匹配图形数据");
            }
            return chart;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入你所要求的图形的英文名称：");
                IChart chart = ChartFactory.GetChart(Console.ReadLine());
                chart.display();
            }
            catch
            {
                Console.WriteLine("请输入标准");
            }
        }
    }
}
