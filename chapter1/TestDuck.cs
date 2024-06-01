using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    public abstract class TestDuck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;
        public TestDuck()
        {

        }
        public abstract void display();
        public void performFly()
        {
            flyBehavior.fly();
        }
        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }

        //cretaed these two new
        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehvior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
