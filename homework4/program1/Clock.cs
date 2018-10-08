using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Clock
    {
        public delegate void Aclock();
        public event Aclock ring;
        public void Ring()
        {
            ring();
        }
    }
}
