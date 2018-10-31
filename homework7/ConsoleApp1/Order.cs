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
        public int ID
        {
            get
            {
                return ID = id;
            }
            set
            {
                id = value;
            }
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

        public Order(string name, string good, double price)
        {
            this.Name = name;
            this.Good = good;
            this.Price = price;
        }
    }
}
