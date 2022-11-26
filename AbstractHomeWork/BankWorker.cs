using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHomeWork
{
    internal class BankWorker : Human
    {
        string bankworker;
        public BankWorker(string name, string surname, string bankworker) : base(name, surname)
        {
            this.name = name;
            this.surname = surname;
            this.bankworker = bankworker;
        }

        public override void InfoDisplay()
        {
            Console.WriteLine($"Name is {name} , surname is {surname}, bank is {bankworker}");
        }
    }
}
