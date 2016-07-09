/*
Add functionality to the phonebook from the previous task to print all contacts ordered lexicographically when 
receive the command “ListAll”.

Examples
Input	                    Output
A Nakov +359888001122       Gero -> 5559393
A RoYaL(Ivan) 666           Nakov -> +359888001122
A Gero 5559393              RoYaL(Ivan) -> 666
A Simo 02/987665544         Simo -> 02/987665544
ListAll	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PhonebookUpgrade
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string row = Console.ReadLine();

            while (!row.Equals("END"))
            {
                if (row.Equals("ListAll"))
                {
                    foreach (var pair in phonebook.OrderBy(e => e.Key))
                    {
                        Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                    }
                }
                else
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
                }

                row = Console.ReadLine();
            }
        }
    }
}
