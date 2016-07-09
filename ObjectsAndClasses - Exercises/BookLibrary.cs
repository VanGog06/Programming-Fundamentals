/*
To model a book library, define classes to hold a book and a library. The library must have a name and a list of books. The books must contain the title, author, publisher, release date, ISBN-number and price. 
Read a list of books, add them to the library and print the total sum of prices by author, ordered descending by price and then by author’s name lexicographically.
Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.

Examples
Input	                                                        Output
5                                                               Tolkien -> 40.25
LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00            JKRowling -> 35.50   
Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25            OBowden -> 14.00
HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50
HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00
AC OBowden PenguinBooks 20.11.2009 0395082555 14.00	
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05.BookLibrary
{
    class BookLibrary
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

            Dictionary<string, decimal> result = new Dictionary<string, decimal>();

            foreach (var singleBook in library.BooksList)
            {
                if (!result.ContainsKey(singleBook.Author))
                {
                    result.Add(singleBook.Author, singleBook.Price);
                }
                else
                {
                    result[singleBook.Author] += singleBook.Price;
                }
            }

            foreach (var pair in result.OrderByDescending(e => e.Value).ThenBy(e => e.Key))
            {
                Console.WriteLine("{0} -> {1:F2}", pair.Key, pair.Value);
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
