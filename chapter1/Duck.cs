using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1
{
    public class Duck
    {
       // public void quack() { }
        public void swim() { }
        public void display() { }
        //public void fly() { }
        //other duck like methods

    }

    public interface Flyable
    {
        public void fly();
    }

    public interface Quackable
    {
        public void quack();
    }
    public class MallardDuck : Duck,Flyable,Quackable
    {
        public void display()
        {
            //looks like mallard
        }
        public void fly() { }
        public void quack() { }
    }

    public class RedHeadDuck : Duck,Flyable,Quackable
    {
        public void display()
        {
            //looks like redhead
        }

        public void fly()
        {
            
        }

        public void quack()
        {
            
        }
    }

    public class RubberDuck : Duck,Quackable
    {
        public void quack()
        {
            //override to Squeak
        }

        public void display()
        {
            //looks like a rubberduck
        }
    }

    public class DecoyDuck : Duck
    {       
        public void display() {//decoy duck
                               }
    }

    // lots of other types of ducks inherit from the duck class...
}
