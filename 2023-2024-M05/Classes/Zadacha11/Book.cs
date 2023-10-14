using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha11
{
    public class Book
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors { get; private set; }

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }
        public override string ToString()
        {
            return $"{this.Title}. {this.Year}. {string.Join(", ", this.Authors)}.";
        }
    }
}
