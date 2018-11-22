using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public void addorder(string id, string name, string good, double price,string phone)
        {
            Order p = new Order(id,name, good, price,phone);
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
        public void Export()
        {
            try
            {
                FileStream fs = new FileStream("序列化.xml", FileMode.Create);
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                xs.Serialize(fs, myorder);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //public void priceover(double price)
        //{
        //    Console.WriteLine($"订单价格大于{price}万元的订单为：");
        //    var orders = from p in myorder
        //                 where p.Price > price
        //                 select p;

        //    foreach (Order p in orders)
        //    {

        //        Console.WriteLine(p.Name + "：" + p.Good + "，" + p.Price + "万元");
        //    }
        //    if (!orders.Any())
        //    {
        //        Console.WriteLine("没有订单小于");
        //    }
        //}

        //public Order serchbyid(string id)
        //{

        //    var orders = from m in myorder
        //                 where m.ID.Equals(id)
        //                 select m;
        //    foreach(Order p in orders)
        //    {

        //        return p;
        //    }
        //    return null;
        //}
    }
}
