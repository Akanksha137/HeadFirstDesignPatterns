using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    public class FlyNoWay:FlyBehavior
    {
        public void fly()
        {
            //do nothing - cant fly
            Console.WriteLine("I cant fly");
        }
    }
}
