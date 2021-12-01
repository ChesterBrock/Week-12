using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    class SnakeAlien : Alien
    {
        private int Damage = 10;

        // Constructor 
        public SnakeAlien(int health, string name) : base(health, name)
        {

        }

        // overriding the method 
        public override int GetDamage()
        {
            return Damage;
        }
    }
}
