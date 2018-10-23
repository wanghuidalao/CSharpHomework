using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    [Serializable]
    public class Order
    {
        private string name;
        private string good;
        private double price;
        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }
        public string Good
        {
            get
            { return good; }
            set
            { good = value; }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public Order()
        {

        }
        public Order(string name, string good, double price)
        {
            this.name = name;
            this.good = good;
            this.price = price;
        }
    }
}
