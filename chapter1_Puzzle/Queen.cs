using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1_Puzzle
{
    public class Queen:Character
    {
        public Queen()
        {
            weapon = new KnifeBehavior();
        }

        public override void fight()
        {
            Console.WriteLine("Queen");
        }
    }
}
