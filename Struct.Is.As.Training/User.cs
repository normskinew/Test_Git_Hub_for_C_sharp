using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.Is.As.Training
{
    internal class User
    {
        private string name;
        private int age;
        public Book Book { get; private set; }
        public User(string name, int age, Book book)
        {
            this.name = name;
            this.age = age;
            Book = book;
        }   
        public void WholeInformation() 
        {
            Console.WriteLine($"Name {name}, Age is {age}");
        }
    }
}
