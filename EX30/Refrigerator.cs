using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Refrigerator : Machine
    {
        public Refrigerator(string n, float wi = 0, float h = 0, float d = 0, float we = 0) : base( n, wi, h, d, we)
        {
        }
    }
}
