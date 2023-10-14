using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Zadacha11
{
    internal class LibraryItarator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex;
        public LibraryItarator(IEnumerable<Book> books)
        {
            Reset();
            this.books = new List<Book>(books);
        }
        public Book Current => this.books[currentIndex];
        object IEnumerator.Current => this.Current;
        public void Dispose()
        {            
        }
        public bool MoveNext() => ++currentIndex < books.Count;
        public void Reset() => currentIndex = -1;
    }
}
