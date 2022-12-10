using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.Is.As.Training
{
    internal struct Book
    {
        private string name;
        private int pages;
        private int year;
        private string autor;
        public Book(string name, int pages, int year, string autor)
        {
            this.name = name;
            this.pages = pages;
            this.year = year;
            this.autor = autor;
        }
        public void printInfoAboutBook()
        {
            Console.WriteLine($"Name of the book is {name}, pages are {pages}, year is {year}, autor is {autor}");
        }
    }
}
