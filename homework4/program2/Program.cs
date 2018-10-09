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
            Order p1 = new Order("张三", "篮球");
            Order p2 = new Order("李四", "网球");
            Order p3 = new Order("王五", "足球");
            order.addorder(p1);//添加订单
            order.addorder(p2);
            order.addorder(p3);
            order.showorder();//打印
            order.searchorder("足球");//搜索
            order.modifyorder(p1, "张三", "羽毛球");//修改
            order.deleteorder(p2);//删除


        }
    }
}
