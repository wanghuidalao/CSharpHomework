using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
   public class Order
    {
       public string name
        {
            get;
            set;
        }
        public string order
        {
            get;
            set;
        }
        public Order(string name,string order)
        {
            this.name = name;
            this.order = order;
        }
    }
}
