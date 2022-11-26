using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHomeWork
{
    public abstract class Human
    {
        protected string? name;
        protected string? surname;
       public Human(string? name, string? surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public abstract void InfoDisplay();
        
    }
}
