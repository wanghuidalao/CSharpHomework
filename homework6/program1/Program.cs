using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderservice = new OrderService();
            orderservice.addorder("张三", "adc", 0.5);
            orderservice.addorder("张五", "fjd", 5);
            orderservice.addorder("赵六", "dv", 0.3);
            orderservice.addorder("李遏", "dffv", 1);
            orderservice.addorder("王者", "gere", 3);
            orderservice.Export();//转为.xml文件
            orderservice.Import();//从.xml文件输出
        }
    }
}
