
/// Chapter No. 12		Exercise No. 1
/// File Name: Program.cs
/// @author: Chester Brock 
/// Date:  Nov 30, 2021
///
/// Problem Statement: Rewrite the code so that inheritance is used to represent the different types of aliens.
/// 
/// 
/// Overall Plan:
/// 1) Split the code into multiple files.
/// 2) Rewrite the code so that inheritance is used to represent the different types of aliens instead of the “type” parameter.
/// 3) rewrite the Alien class to hide the instance variables
/// 4) create a GetDamage method for each derived class that returns the amount of damage the alien inflicts.
/// 5) rewrite the CalculateDamage method to use GetDamage and write a Main method that tests the code.
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo
            AlienPack pack1 = new AlienPack(4);

            SnakeAlien snake1 = new SnakeAlien(220, "Viper");
            OgreAlien orge1 = new OgreAlien(760, "Orge Behemoth");
            MarshallowManAlien marsh1 = new MarshallowManAlien(57, "plushmen");

            // add to pack. 
            pack1.AddAlien(marsh1, 0);
            pack1.AddAlien(snake1, 1);
            pack1.AddAlien(marsh1, 2);
            pack1.AddAlien(snake1, 3);
            // output should be 22


            // displaying the damage
            Console.WriteLine("Total Damage: " + pack1.CalculateDamage());

            
            Console.ReadLine();



        }
    }
}
