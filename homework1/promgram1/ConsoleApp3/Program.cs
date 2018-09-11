using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入第一个数字：");
            string s = Console.ReadLine();
            double a = double.Parse(s);
            Console.Write("输入第二个数字：");
            string n = Console.ReadLine();
            double b = double.Parse(n);
            Console.WriteLine("它们的积为：" + (a * b));
        }
    }
}
