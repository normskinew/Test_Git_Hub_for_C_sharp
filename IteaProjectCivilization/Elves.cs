using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IteaProjectCivilization.Events;

namespace IteaProjectCivilization
{
    internal class Elves : Civilization, IResource
    {
        
       
        public Elves()
        {
            AttackPower = 100;
            Defense = 15;
            CurrentPopulation = 1000;
            Console.ForegroundColor = ConsoleColor.Cyan;   
            Console.WriteLine($"Characteristics of Elves are : AttackPower {AttackPower}, Defense {Defense}, CurrentPopulation {CurrentPopulation}");

        }
       
        public void diseaseForElves(object sender, CustomArgs e)
        {
            AttackPower = AttackPower - (AttackPower * e._percentage / 100);
            Defense = Defense - (Defense * e._percentage / 100);
            CurrentPopulation = CurrentPopulation - (CurrentPopulation * e._percentage / 100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Unknowing disease has come to Elves, Attack power was reduced to {AttackPower} , Defense to {Defense}, population to {CurrentPopulation}");
        }
        public void starvationForElves(object sender, CustomArgs e)
        {
            AttackPower = AttackPower - (AttackPower * e._percentage / 100);
            Defense = Defense - (Defense * e._percentage / 100);
            CurrentPopulation = CurrentPopulation - (CurrentPopulation * e._percentage / 100);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Starvation has come to Elves, Attack power was reduced to {AttackPower} , Defense to {Defense}, population to {CurrentPopulation}");
        }

    }
}
