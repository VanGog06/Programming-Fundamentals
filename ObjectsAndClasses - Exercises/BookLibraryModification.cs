/*
Use the classes from the previous problem and make a program that read a list of books and print all titles released after given date ordered by date and then by title lexicographically. The date is given if format “day-month-year” at the last line in the input.

Examples
Input	                                                        Output
5                                                               HP1 -> 26.06.1997
LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00            HP7 -> 21.07.2007
Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25            AC -> 20.11.2009    
HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50
HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00
AC OBowden PenguinBooks 20.11.2009 0395082555 14.00
30.07.1954	
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            Library library = new Library();

            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] bookArgs = Console.ReadLine().Split();

                Book book = new Book();

                book.Title = bookArgs[0];
                book.Author = bookArgs[1];
                book.Publisher = bookArgs[2];
                book.ReleaseDate = DateTime.ParseExact(bookArgs[3], "d.M.yyyy", CultureInfo.InvariantCulture);
                book.ISBN = int.Parse(bookArgs[4]);
                book.Price = decimal.Parse(bookArgs[5]);

                library.BooksList.Add(book);
            }

            DateTime releaseDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();

            foreach (var singleBook in library.BooksList)
            {
                if (singleBook.ReleaseDate > releaseDate)
                {
                    if (!result.ContainsKey(singleBook.Title))
                    {
                        result.Add(singleBook.Title, singleBook.ReleaseDate);
                    }
                    else
                    {
                        result[singleBook.Author] = singleBook.ReleaseDate;
                    }
                }
            }

            foreach (var pair in result.OrderBy(e => e.Value).ThenBy(e => e.Key))
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value.Date.ToString("d.MM.yyyy"));
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public int ISBN { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> BooksList { get; set; }

        public Library()
        {
            this.BooksList = new List<Book>();
        }
    }
}
