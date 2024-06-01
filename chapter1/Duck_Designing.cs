using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    public class Duck_Designing
    {
        FlyBehavior flyBehavior;
        QuackBehavior quackBehavior;

        public void performQuack() {
            quackBehavior.quack();
        }
        public void swim() { }
        public void display() { }
        public void performFly() { 
        flyBehavior.fly();
        }
        //other duck methods
    }
}
