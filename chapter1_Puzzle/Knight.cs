using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1_Puzzle
{
    public class Knight:Character
    {
        public Knight()
        {
            weapon = new AxeBehavior();
        }
        public override void fight()
        {
            Console.WriteLine("Knight");
        }
    }
}
