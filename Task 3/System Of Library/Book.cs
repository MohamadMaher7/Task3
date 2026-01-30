using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.System_Of_Library
{
    internal class Book
    {
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Availability = true;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availability { get; set; }

        
    }
}
