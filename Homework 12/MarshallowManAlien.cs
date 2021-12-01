using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    class MarshallowManAlien : Alien
    {
        private int Damage = 1;

        // Constructor 
        public MarshallowManAlien(int health, string name) : base( health, name)
        {

        }

        public override int GetDamage()
        {
            return Damage;
        }
    }
}
