using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteaProjectCivilization
{
    internal interface IResource
    {
        public ushort Wood
        {
            set { if (value <= 0)
                {
                    Wood = 0;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"The Wood resource is reached {Wood}, Sir, we must work much better");
                }
                if (value >= 600) 
                    Wood = 600;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"The Wood resource is reached {Wood}, it's maximun amount, My Lord, we are very great with it");
            }
            get { return Wood; }
        }
       
        public ushort Food
        {
            set
            {
                if (value <= 0)
                {
                    Food = 0;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"The Food resource is reached {Food}, Sir, we must work much better");
                }
                if (value >= 600)
                {
                    Food = 600;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"The Food resource is reached {Food}, it's maximun amount, My Lord, we are very great with it");
                }
            }
            get { return Food; }
        }
        

    }
}
