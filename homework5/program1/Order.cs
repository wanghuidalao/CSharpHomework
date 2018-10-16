using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Order
    {
        public string name
        {
            get;
            set;
        }
        public string good
        {
            get;
            set;
        }
        public double price;
     
        public Order(string name, string good,double price)
        {
            this.name = name;
            this.good = good;
            this.price = price;
        }
    }
}
