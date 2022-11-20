using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesTraining
{
    public abstract class Humans
    {
        public abstract void talk();
        public abstract void walk();
        public virtual void Doing()
        {
            Console.WriteLine("Nothing");
        }


    }
}
