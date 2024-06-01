using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    public class Quack:QuackBehavior
    {
        public void quack()
        {
            //implements duck quacking
            Console.WriteLine("Quack");
        }
    }
}
