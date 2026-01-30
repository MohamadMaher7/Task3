using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.System_Of_Library
{
    internal class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book added: {book.Title}");
        }

        public void BorrowBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.Contains(title))
                {
                    if (books[i].Availability)
                    {
                        books[i].Availability = false;
                        Console.WriteLine($"You borrowed: {books[i].Title}");
                    }
                    else
                    {
                        Console.WriteLine($"Book already borrowed: {books[i].Title}");
                    }
                    return;
                }
            }

            Console.WriteLine($"Book not found: {title}");
        }

        public void ReturnBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.Contains(title))
                {
                    if (!books[i].Availability)
                    {
                        books[i].Availability = true;
                        Console.WriteLine($"You returned: {books[i].Title}");
                    }
                    else
                    {
                        Console.WriteLine($"Book was not borrowed: {books[i].Title}");
                    }
                    return;
                }
            }
            Console.WriteLine($"Book not found: {title}");
        }
    }
}
