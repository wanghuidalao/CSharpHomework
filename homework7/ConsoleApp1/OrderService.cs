using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
     public class OrderService
    {
        List<Order> myorder = new List<Order>();
        public List<Order> Myorder
        {
            get
            {
                return Myorder = myorder;
            }
            set
            {
                myorder = value;
            }
        }
        public void addorder(string name, string good, double price)
        {
            Order p = new Order(name, good, price);
            myorder.Add(p);
        }
        public void showorder()
        {
            foreach (Order p in myorder)
            {
                Console.WriteLine(p.Name + "：" + p.Good + "，" + p.Price + "万元");
            }
        }
        public Order serchbyname(string name)
        {
            
            var order = from p in myorder
                        where p.Name.Equals(name)
                        select p;
            foreach (Order p in order)
            {
                return p;
            }
            if (!order.Any())
            {
                Console.WriteLine("查无此人");
            }
            return null;
        }
        public Order serchbygood(string good)
        {

            var orders = from p in myorder
                         where p.Good.Equals(good)
                         select p;

            foreach (Order p in orders)
            {
                return p;
            }
            if (!orders.Any())
            {
                Console.WriteLine("查无此人");
            }
            return null;
        }
        public void priceover(double price)
        {
            Console.WriteLine($"订单价格大于{price}万元的订单为：");
            var orders = from p in myorder
                         where p.Price > price
                         select p;

            foreach (Order p in orders)
            {

                Console.WriteLine(p.Name + "：" + p.Good + "，" + p.Price + "万元");
            }
            if (!orders.Any())
            {
                Console.WriteLine("没有订单小于");
            }
        }
    }
}
