using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person:Animal
    {
        public Person(DateTime bd, string n, float wi = 0, float h = 0, float d = 0, float we = 0, int l = 0, int a = 0) : base(bd, n, wi, h, d, we, l, a)
        {
            
        }
    }
}
