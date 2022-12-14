using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IteaProjectCivilization.Events;

namespace IteaProjectCivilization
{
    internal class Orcs : Civilization
    {


        public Orcs()
        {
            AttackPower = 60;
            Defense = 30;
            CurrentPopulation = 1000;
            Food = 200;

            Console.WriteLine($"Characteristics of Orcs are : AttackPower {AttackPower}, Defense {Defense}, CurrentPopulation {CurrentPopulation}, Food {Food}");

        }

        public override void populationGeneration(int populationPerDay)
        {
            base.populationGeneration(populationPerDay);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Population of the Orcs are {CurrentPopulation}");

        }
        public override void resGenPerDay(int food)
        {
            base.resGenPerDay(food);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Food of the Orcs are {Food}");
        }

        public void diseaseForOrcs(object sender, CustomArgs e)
        {
            AttackPower = AttackPower - (AttackPower * e._percentage / 100);
            Defense = Defense - (Defense * e._percentage / 100);
            CurrentPopulation = CurrentPopulation - (CurrentPopulation * e._percentage / 100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Unknowing disease has come to Orcs, Attack power was reduced to {AttackPower} , Defense to {Defense}, population to {CurrentPopulation}");
        }
        public void starvationForOrcs(object sender, CustomArgs e)
        {

            Food = Food - (Food * e._percentage / 100);
           

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Starvation has come to Orcs, Food was reduced to {Food}");
        }
        public void engineeringForOrcs(object sender, CustomArgs e)
        {
            AttackPower = AttackPower + (AttackPower * e._percentage / 100);
            Defense = Defense + (Defense * e._percentage / 100);
          
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Orcs enginners researched new upgrades, Attack power was increased to {AttackPower} , Defense to {Defense}");
            ;
        }
    }
}
