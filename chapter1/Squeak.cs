using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    public class Squeak:QuackBehavior
    {
        public void quack()
        {
            //rubber duck squeak
            Console.WriteLine("Squeak");
        }
    }
}
