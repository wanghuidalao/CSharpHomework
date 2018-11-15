using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    public class Order
    {
        public string Name
        {
            get;
            set;
        }
        public string Good
        {
            get;
            set;
        }
        public int id;
        public string ID
        {
            get;


            set;
            
        }
        public double price;
        public double Price
        {
            get
            {
                return Price = price;
            }
            set
            {
                price = value;
            }
        }
        public string Phone
        {
            get;
            set;
        }
        public Order()
        {

        }
        public Order(string id,string name, string good, double price,string phone)
        {
            this.ID = id;
            this.Name = name;
            this.Good = good;
            this.Price = price;
            this.Phone = phone;
        }
    }
}
