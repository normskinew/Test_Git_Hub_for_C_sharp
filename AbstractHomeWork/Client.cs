using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHomeWork
{
    internal class Client : Human
    {
        string bank;
        public Client(string name, string surname, string bank) : base(name, surname)
        {
            this.name = name;
            this.surname = surname;
            this.bank = bank;
        }

      
        public override void InfoDisplay()
        {
            Console.WriteLine($"Name is {name} , surname is {surname}, bank is {bank}");
        }
    }
}
