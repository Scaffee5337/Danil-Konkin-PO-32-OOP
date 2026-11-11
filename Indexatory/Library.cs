using System;
using System.Collections.Generic;
using System.Text;

namespace Indexatory
{
    public class Library
    {
        private Book[] books;
        public Library(Book[] initialBooks) => books = initialBooks;
        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length) return books[index];
                else throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < books.Length) books[index] = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
    }
}
