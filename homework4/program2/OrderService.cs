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
        public void addorder(string name ,string order)
        {
            Order p = new Order(name, order);
    
            myorder.Add(p);
        }

        public void deleteorder(Order order)
        {
            if(myorder.Contains(order ))
            {
                myorder.Remove(order);
            }
        }

        public void modify(Order order)
        {
            if(myorder.Contains(order))
            {
                order.name = "xiaohong";
                order.order = "hhh";               
            }
        }
    }
        
}
