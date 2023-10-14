using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Zadacha11
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryItarator(this.books);
        }

        IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
        {
            foreach (var item in books)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
