using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    class OgreAlien : Alien
    {
        private int Damage = 6;

        // Constructor 
        public OgreAlien(int health, string name) : base( health, name)
        {

        }
        
        
        public override int GetDamage()
        {
            return Damage;
        }
    }
}
