using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace Homework
{
   class program
    {
        static void Main(string[] args)
        {
            Runring Runring = new Runring();
            Clock clock = new Clock();
            clock.ring += new Clock.Aclock(Runring.Run);
            
            while(true)
            {
                string time = DateTime.Now.ToLongTimeString();
                Console.WriteLine(time);
                System.Threading.Thread.Sleep(1000);
               
                if (time.Equals("13:31:35"))
                {
                    break;
                }
                Console.Clear();
            }
            clock.Ring();
        }
       
    }
}
