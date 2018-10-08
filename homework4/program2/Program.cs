using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService order = new OrderService();
            order.addorder("张三", "篮球");
            order.addorder("赵四", "羽毛球");
            order.addorder("王五", "排球");
         

        }
    }
}
