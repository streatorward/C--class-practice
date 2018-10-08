// Create a few (4 or so) instances of books and use the method on your
// Library class to add them to the list of books in an instance of Library

using System;
using System.Collections.Generic;

namespace Library {
    class Program {
        static void Main (string[] args) {
            Book endersGame = new Book () {
                Title = "Ender's Game",
                Author = "Orsen Scott",
                ISBN = "ABC123"
            };
            Book harryPotter = new Book () {
                Title = "Harry Potter and the Chamber of Secrets",
                Author = "J.K. Rowling",
                ISBN = "123ABC"
            };
            Book lotr = new Book () {
                Title = "Lord of the Rings",
                Author = "J R R Tolkien",
                ISBN = "QAZWSX1234"
            };
            Book twilight = new Book () {
                Title = "Twilight",
                Author = "Stephen Meyers",
                ISBN = "1234XSWZAQ",
                IsAvailble = false
            };

            Book book1 = new Book () {
                Title = "Book1",
                Author = "Author1",
                ISBN = "1A"
            };
            Book book2 = new Book () {
                Title = "Book2",
                Author = "Author2",
                ISBN = "2B"
            };

            List<Book> books = new List<Book> () {
                book1, book2
            };
            Library library = new Library (books, "Downtown Library", "123 Some St. Nashville, TN 12345");

            library.AddToInventory (endersGame);
            library.AddToInventory (lotr);
            library.AddToInventory (harryPotter);
            library.AddToInventory (twilight);

            foreach(Book book in books)
            {
                if(book.IsAvailble)
                {
                    Console.WriteLine($"{book.Title}");
                }
            }
        }
    }
}