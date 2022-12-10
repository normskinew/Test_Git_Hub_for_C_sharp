using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.Is.As.Training
{
    internal class Admin : User
    {
        private string position; 
        public Admin(string name, int age, Book book, string position) : base(name, age, book)
        {
            this.position = position;
        }
    }
}
