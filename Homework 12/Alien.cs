using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    class Alien
    {
        // instance variables 
        private int type;
        private int health; // 0 = dead, 100 = full
        private string name;

        public int Type { get => type; set => type = value; }
        public int Health { get => health; set => health = value; }
        public string Name { get => name; set => name = value; }

        //Constructor 
        public Alien(int health, string name)
        {
            // this.Type = type; - the complete deletion of the type parameter 
            this.Health = health;
            this.Name = name;
        }

        // get damage method 
        public virtual int GetDamage()
        {
            return 0;
        }
    }
}
