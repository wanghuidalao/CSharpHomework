using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int[] num = new int[100];

                for (int i = 0; i < 100; i++)
                {
                    num[i] = i + 1;
                }
                num[0] = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (num[i] != 2 && (num[i] % 2 == 0))
                    {
                        num[i] = 0;
                    }
                    if (num[i] != 3 && (num[i] % 3 == 0))
                    {
                        num[i] = 0;
                    }
                    if (num[i] != 5 && (num[i] % 5 == 0))
                    {
                        num[i] = 0;
                    }
                    if (num[i] != 7 && (num[i] % 7 == 0))
                    {
                        num[i] = 0;
                    }
                    if (num[i] != 11 && (num[i] % 11 == 0))
                    {
                        num[i] = 0;
                    }
                }
                for (int i = 0; i < 100; i++)
                {
                    if (num[i] != 0)
                    {
                        Console.Write(" " + num[i]);
                    }
                }
            
        }
    
    }
}
