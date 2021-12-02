/// Chapter No. 12		Exercise No. 1
/// File Name: Program.cs
/// @author: Chester Brock 
/// Date:  Nov 30, 2021
///
/// Problem Statement: Create a phone lookup program.
/// 
/// 
/// Overall Plan:
/// 1)  add, delete, and find phones number using the dictionary collections. 
/// 2) The key will be a person’s name
///  
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Week_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string name,pNumber;
            // Dictionary
            Dictionary<string, string> phoneLookup = new Dictionary<string, string>();

            // menu
            do
            {
                Console.WriteLine("\n~~Menu~~\n1) add a number\n2) delete a number\n3) find number\n4) Print all contacts\n5) Exit");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("person name : ");
                        name = Console.ReadLine();
                        Console.WriteLine(name + "'s number : ");
                        pNumber = Console.ReadLine();
                        phoneLookup.Add(name, pNumber);
                        break;

                    case 2:
                        Console.WriteLine("Name of person to delete?");
                        name = Console.ReadLine();
                        if (phoneLookup.ContainsKey(name))
                        {
                            phoneLookup.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine("Person not found.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Name for number? :");
                        name = Console.ReadLine();
                        foreach(KeyValuePair<string, string> ele in phoneLookup)
                        {
                            if (ele.Key == (name))
                            {
                                Console.WriteLine("Found : " + ele.Value);
                            }
                            else
                            {
                                Console.WriteLine("Name not found");
                            }

                        }
                        break;
                    case 4:
                        foreach(KeyValuePair<string, string> ele in phoneLookup)
                        {
                            Console.WriteLine("name: {0}  Phone Number: {1}", ele.Key,ele.Value );
                                
                        }
                        break;
                    default:
                        Console.WriteLine("Not a valid choice please try again. ");
                        break;
                }
            } while (choice != 5);


        } // end of main 


    } // ends of class
}
