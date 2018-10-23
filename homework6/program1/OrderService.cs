using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace program1
{
    public class OrderService
    {

        List<Order> myorder = new List<Order>();
        public List<Order> Myorder
        {
            get
            {
                return myorder;
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

        List<Order> orders = new List<Order>();
        public List<Order> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                orders = value;
            }
        }

        public void Import()
        {
            try
            {
               
                FileStream fs = new FileStream("序列化.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                orders = (List<Order>)xs.Deserialize(fs);
             
                foreach(var p in orders)
                {
                    Console.WriteLine(p.Name + "：" + p.Good + "，" + p.Price +"万元");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
