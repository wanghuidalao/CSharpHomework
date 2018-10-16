using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Orderservice
    {
        List<Order> myorder = new List<Order>();
        public void addorder(string name,string good,double price)
        {
            Order p = new Order(name, good, price);
            myorder.Add(p);
        }
        public void showorder()
        {
            foreach(Order p in myorder)
            {
                Console.WriteLine(p.name+"："+p.good+"，"+p.price+"万元");
            }
        }
        public void serchbyname(string name)
        {

            var orders = from p in myorder
                         where p.name.Equals(name)
                         select p;

            foreach (Order p in orders )
            {
                Console.WriteLine("按名字搜索的订单为："+p.name + "：" + p.good + "，" + p.price + "万元");
            }
        }
        public void serchbygood(string good)
        {

            var orders = from p in myorder
                         where p.good.Equals(good)
                         select p;

            foreach (Order p in orders)
            {
                Console.WriteLine("按商品名称搜索的订单为：" + p.name + "：" + p.good + "，" + p.price + "万元");
            }
        }
        public void priceover(double price)
        {
            Console.WriteLine($"订单价格大于{price}万元的订单为：");
            var orders = from p in myorder
                         where p.price > price
                         select p;

            foreach (Order p in orders)
            {

                Console.WriteLine(p.name + "：" + p.good + "，" + p.price + "万元");
            }
        }
    }
}
