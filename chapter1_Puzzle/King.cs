using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1_Puzzle
{
    public class King:Character
    {
        public King()
        {
            weapon = new SwordBehavior();
        }
        public override void fight()
        {
            Console.WriteLine("King");
        }
    }
}
