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
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"The Wood resource is reached {Wood}, Sir, we must work much better");
                }
                if (value >= 600) 
                    Wood = 600;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"The Wood resource is reached {Wood}, it's maximun amount, My Lord, we are very great with it");
            }
            get { return Wood; }
        }
        public ushort Coal
        {
            set { if (value <= 0) Coal = 0; if (value >= 800) Coal = 800; }
            get { return Coal; }
        }
        public ushort Food
        {
            set { if (value <= 0) Food = 0; }
            get { return Food; }
        }
        public ushort Steal
        {
            set { if (value <= 0) Steal = 0; }
            get { return Steal; }
        }

        public virtual void dailyResIncome(ushort wIncomeC, ushort cIncomeC, ushort fIncomeC, ushort sIncomeC) {}

    }
}
