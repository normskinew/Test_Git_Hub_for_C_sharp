using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesTraining
{
    internal class UFO : Humans
    {
        public override void talk()
        {
            Console.WriteLine("alients");
        }

        public override void walk()
        {
            Console.WriteLine("by alient foot");
        }
        public override void Doing()
        {
            base.Doing();
            Console.WriteLine("alient work");
        }
    }
}
