using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    // this class is seems like a repository pattern...???

    public class MallardDuck_final:Duck_Designing
    {
        FlyBehavior flyBehavior;
        QuackBehavior quackBehavior;
        public MallardDuck_final()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public void display()
        {
            Console.WriteLine("I'm  a real mallard duck");
        }
    }
}
