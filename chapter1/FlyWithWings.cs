using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    public class FlyWithWings:FlyBehavior
    {
        public void fly()
        {
            //implements duck flying
            Console.WriteLine("I'm flying");
        }
    }
}
