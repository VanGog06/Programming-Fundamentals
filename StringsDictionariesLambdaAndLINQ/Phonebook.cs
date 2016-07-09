/*
Write a program that receives some info from the console about people and their phone numbers. Each entry should have just one name and one number (both of them strings). 
On each line you will receive some of the following commands:
•	A {name} {phone} – adds entry to the phonebook. In case of trying to add a name that is already in the phonebook you should change his phone number with the new one provided.
•	S {name} – searches for a contact by given name and prints print details in format "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist."
•	END – stop receiving more commands

Examples
Input	                        Output
A Nakov 0888080808              Contact Mariika does not exist.
S Mariika                       Nakov -> 0888080808
S Nakov
END	

A Nakov +359888001122           Simo -> 02/987665544
A RoYaL(Ivan) 666               Contact simo does not exist.
A Gero 5559393                  Contact RoYaL does not exist.
A Simo 02/987665544             RoYaL(Ivan) -> 666
S Simo
S simo
S RoYaL
S RoYaL(Ivan)
END	

A Misho +359883123              Misho -> 02/3123
A Misho 02/3123
S Misho
END	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string row = Console.ReadLine();

            while (!row.Equals("END"))
            {
                string[] stringRow = row.Split().ToArray();

                string command = stringRow[0];
                string name = stringRow[1];
                string number = string.Empty;

                if (stringRow.Length == 3)
                {
                    number = stringRow[2];
                }

                if (command.Equals("A"))
                {
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, number);
                    }
                    else
                    {
                        phonebook[name] = number;
                    }
                }
                else
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }

                row = Console.ReadLine();
            }
        }
    }
}
