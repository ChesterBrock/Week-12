using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    class AlienPack
    {
        private Alien[] aliens;


        public AlienPack(int numAliens) // constructor with one param
        {
            aliens = new Alien[numAliens]; // creates memory for n aliens
        }
        public void AddAlien(Alien newAlien, int index) // adding alien to the index 
        {
            aliens[index] = newAlien;
        }
        public Alien[] GetAliens()
        {
            return aliens;
        }


        public int CalculateDamage()
        {
            // rewrite the calculateDamage method. 
            int totalDamage = 0; // answer
            for(int i = 0; i < aliens.Length; i++)
            {
                totalDamage += aliens[i].GetDamage();
            }
            
            return totalDamage;
        }
    }

}
