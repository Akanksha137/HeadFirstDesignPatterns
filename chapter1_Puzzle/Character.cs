using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1_Puzzle
{
    public abstract class Character
    {
        public WeaponBehavior weapon;

        public void setWeapon(WeaponBehavior w)
        {
            this.weapon = w;
        }
        public abstract void fight();

    }
}
