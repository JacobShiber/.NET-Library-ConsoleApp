using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1 - 
            string[] names = new string[7]
            {
                "Eden",
                "Jacob",
                "Avi",
                "Ermias",
                "Amir",
                "Eliyahu",
                "Yoni"
            };

            IEnumerable<string> namesWithE =  from name in names
                                              where name[0] == 'E'
                                              select name;

            //task 2 - 

            Random ran = new Random();

            int[] randomAges = new int[10];
            
            for(int i = 0; i < 10; i++)
            {
                randomAges[i] = ran.Next(30);
            }

            IEnumerable<int> agesAbove20 = from age in randomAges
                                           where age > 20
                                           select age;

            //task 3 - 

            GetLongerBooks(CreateBooksArray());

            //task 4 - 

            GetAuthorNames(CreateBooksArray());

            //task 5 - 

            FindShortesBook(CreateBooksArray());

            //task 6 - 

            GetBookThatEndWithY(CreateBooksArray());

            //task 7 - 

            foreach(IGrouping<string,Book> author in groupByAuthorName(CreateBooksArray()))
            {
                Console.WriteLine(author.Key);
                foreach(Book authorDetails in author)
                {
                    Console.WriteLine($"Book Name : {authorDetails.BookName} Pages : {authorDetails.PageAmount}");
                }
            }

        }

        static Book[] CreateBooksArray()
        {
            Random ran = new Random();

            Book[] booksArray = new Book[6]
            {
                new Book("The Fall", "Arnold", ran.Next(500)),
                new Book("Dark Mages", "Arnold", ran.Next(500)),
                new Book("The Rise", "Peter", ran.Next(500)),
                new Book("Half & Half", "Dan", ran.Next(500)),
                new Book("Black Hawk", "Peter", ran.Next(500)),
                new Book("Rush", "Dan", ran.Next(500)),
            };

            return booksArray;
        }

        static Book FindShortesBook(Book[] booksArray)
        {
            Book shortestBook = Array.Find(booksArray, book => book.PageAmount < 150);

            return shortestBook;
        }

        static IEnumerable<Book> GetAuthorNames(Book[] booksArray1)
        {
            IEnumerable<Book> authorNameList = from book in booksArray1
                                               where book.Author.Length > 4
                                               select book;

            return authorNameList;
        }

        static IEnumerable<Book> GetLongerBooks(Book[] booksArray2)
        {
            IEnumerable<Book> booksAbove200Pages = from book in booksArray2
                                                   where book.PageAmount > 200
                                                   select book;

            return booksAbove200Pages;
        }

        static IEnumerable<Book> GetBookThatEndWithY(Book[] booksArray3)
        {
            IEnumerable<Book> books = from book in booksArray3
                                      where book.BookName[book.BookName.Length - 1] == 'y'
                                      select book;

            return books;
        }

        static IEnumerable<IGrouping<string, Book>> groupByAuthorName(Book[] booksArray4)
        {
            IEnumerable<IGrouping<string, Book>> group = from book in booksArray4
                                                         group book by book.Author;

            return group;
        }
    }
}
