/*
Write a program that generate random fake advertisement message to extol some product. The messages must consist of 4 parts: laudatory phrase + event + author + city. Use the following predefined parts:
•	Phrases – {“Excellent product.”, “Such a great product.”, “I always use that product.”, “Best product of its category.”, “Exceptional product.”, “I can’t live without this product.”}
•	Events – {“Now I feel good.”, “I have succeeded with this product.”, “Makes miracles. I am happy of the results!”, “I cannot believe but now I feel awesome.”, ”Try it yourself, I am very satisfied.”, “I feel great!”}
•	Author – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}
•	Cities – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}
The format of the output message is: {phrase} {event} {author} – {city}.
As an input you take the number of messages to be generated. Print each random message at a separate line.

Examples
Input	        Output
3	            Such a great product. Now I feel good. Elena – Ruse
                Excelent product. Makes miracles. I am happy of the results! Katya – Varna
                Best product of its category. That makes miracles. Eva - Sofia
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] { "Excellent product.", "Such a great product.",
                                              "I always use that product.", "Best product of its category.",
                                              "Exceptional product.", "I can’t live without this product."};

            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.",
                                             "Makes miracles. I am happy of the results!",
                                             "I cannot believe but now I feel awesome.",
                                             "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0} {1} {2} - {3}", phrases[rnd.Next(0, phrases.Length)],
                                                       events[rnd.Next(0, events.Length)],
                                                       authors[rnd.Next(0, authors.Length)],
                                                       cities[rnd.Next(0, cities.Length)]);
            }
        }
    }
}
