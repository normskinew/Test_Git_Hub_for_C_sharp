using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace IteaProjectCivilization
{
    public abstract class Civilization
    {
        public const int maxPopulation = 5000;
        private int currentPopulation = 0;
        private int attackPower = 0;
        private int defense = 0;
        private int food = 0;
        public int CurrentPopulation
        {
            set
            {
                if (value <= 0) currentPopulation = 0;
                else if (value >= maxPopulation) currentPopulation = maxPopulation;
                else currentPopulation = value;
            }
            get { return currentPopulation; }
        }

        public int AttackPower
        {
            set 
            { 
                if (value <= 0) attackPower = 0;
                else if (value >= 500) attackPower = 500;
                else attackPower = value;
            }
            get { return attackPower; }
        }
        public int Defense
        {
            set
            {
                if (value <= 0) defense = 0;
                else if (value >= 500) defense = 500;
                else defense = value;
            }
            get { return defense; }
        }
        public int Food
        {
            set
            {
                if (value <= 0)
                {
                    food = 0;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"The Food resource is reached {food}, Sir, we must work much better, we will die");
                }
                else if (value >= 20000)
                {
                    food = 20000;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"The Food resource is reached {food}, it's maximun amount, My Lord, i cannot to save more");
                }
                else food = value;

            }
            get { return food; }
        }
        public virtual void resGenPerDay(int food_par)
        {
            int res = food * food_par / 100;
            food += res;
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Our people earned per day {res} foods");
        }
        public virtual void populationGeneration(int populationPerDay)
        {
            int addCurrentPopulation = (currentPopulation * populationPerDay / 100);
            currentPopulation += addCurrentPopulation;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"This day born {addCurrentPopulation}");
        }


    }
}
