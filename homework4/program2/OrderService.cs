using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class OrderService
    {
        List<Order> myorder = new List<Order>();
        public void addorder(Order p)
        { 
            myorder.Add(p);
        }
        public void showorder()
        {
            foreach(Order p in myorder)
            {
                Console.WriteLine(p.name + ":" + p.order);
            }
        }
        public void deleteorder(Order order)
        {
        
            if(myorder.Contains(order ))
            {
                int n = myorder.IndexOf(order);
                
                Console.WriteLine(order.name + "的订单取消了，这是新订单：");
                myorder.RemoveAt(n);
                foreach (Order p in myorder)
                {
                    Console.WriteLine(p.name + ":" + p.order);
                }
               
            }
            else
            {
                Console.WriteLine("不存在此订单");
            }
        }

        public void modifyorder(Order order,string newname,string neworder)
        {
            if(myorder.Contains(order))
            {
                int n = myorder.IndexOf(order);
                myorder[n].name = newname;
                myorder[n].order = neworder;
                Console.WriteLine("修改后的订单：");
                foreach (Order p in myorder)
                {
                    Console.WriteLine(p.name + ":" + p.order);
                }
            }
            else
            {
                Console.WriteLine("不存在此订单");
            }
        }
        public void searchorder(string str)
        {
            foreach(Order p in myorder)
            {
                if(p.name.Equals(str)||p.order.Equals(str))
                {
                    Console.WriteLine("搜索结果为：" + p.name+"：" + p.order);
                }
            }
        }
    }
        
}
