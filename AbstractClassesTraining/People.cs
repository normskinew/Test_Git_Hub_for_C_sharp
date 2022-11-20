using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesTraining
{
    internal class People : Humans
    {
        public override void talk()
        {
            Console.WriteLine("Englith");
        }

        public override void walk()
        {
            Console.WriteLine("by foot");
        }
        public override void Doing()
        {
           
            Console.WriteLine("people work");
        }
    }
}
