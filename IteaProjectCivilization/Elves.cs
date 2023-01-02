using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IteaProjectCivilization.Events;

namespace IteaProjectCivilization
{
    internal class Elves : Civilization
    {
        
       
        public Elves()
        {
            AttackPower = 115;
            Defense = 20;
            CurrentPopulation = 500;
            Food = 300;
              
            Console.WriteLine($"Characteristics of Elves are : AttackPower {AttackPower}, Defense {Defense}, CurrentPopulation {CurrentPopulation}, Food {Food}");

        }

        public override void populationGeneration(int populationPerDay)
        {
            base.populationGeneration(populationPerDay);
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine($"Population of the Elves are {CurrentPopulation}");

        }
        public override void resGenPerDay(int food)
        {
            base.resGenPerDay(food);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Food of the Elves are {Food}");
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
           
            Food = Food - (Food * e._percentage / 100);
            
           
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Starvation has come to Elves, Food was reduced to {Food}");
        }
        public void engineeringForElves(object sender, CustomArgs e)
        {
            AttackPower = AttackPower + (AttackPower * e._percentage / 100);
            Defense = Defense + (Defense * e._percentage / 100);
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Elves enginners researched new upgrades, Attack power was increased to {AttackPower} , Defense to {Defense}");
           ;
        }
    }
}
