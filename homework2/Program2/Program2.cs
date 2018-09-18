using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 2, 6, 54, 5, 8, 6, 4,9,1 };
            int max = num[0];
            int min = num[0];
            int sum = 0;
            
            int n = num.Length;
            for (int i = 0;i < n;i++)
            {
                if(num[i] > max)
                {
                    max = num[i];
                }
                if (num[i]<min)
                {
                    min = num[i];
                }
                
                sum += num[i];
            }
            Console.WriteLine("数组的最大值为：" + max);
            Console.WriteLine("数组的最小值为：" + min);
            Console.WriteLine("数组的和为：" + sum);
            Console.WriteLine("数组的平均值为：" + ((double)sum/n));
        }
    }
}
