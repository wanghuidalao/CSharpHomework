using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个整数：");
            try
            {
                int n = 0;
                n = int.Parse(Console.ReadLine());
                Console.Write(n + "=");
                for (int i = 2; i <= (n / 2); i++)
                {
                    if (n % i == 0)
                    {
                        n = n / i;
                        Console.Write(i + "*");
                        i = 1;
                    }
                }
                Console.WriteLine(n + "");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
