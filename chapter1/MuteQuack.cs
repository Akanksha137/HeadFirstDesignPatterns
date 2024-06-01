using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    public class MuteQuack:QuackBehavior
    {
        public void quack()
        {
            //do nothing - cant quack
            Console.WriteLine("Silence");
        }
    }
}
