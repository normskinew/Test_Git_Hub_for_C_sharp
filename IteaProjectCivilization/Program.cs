using IteaProjectCivilization;
using System;
using System.ComponentModel;
using System.Drawing;

internal class Program
{
    private static int time = 1000;
    private static int deltatime = 1000;
    private static bool isGamePlay = true;
    private static int endDay;
    private static void Main(string[] args)       
    {
        Console.Title = "Game: Civilization";
        Console.WriteLine("Press any key to start the Civilization game");
        Console.ReadKey();
        int rndEventGen()
         {
            Random rnd = new Random();
            int i = rnd.Next(0, 10);
            return i;
         }
        Events events = new Events();
        Elves elves = new Elves();
        Orcs orcs = new Orcs();
        events.OnDisease += orcs.diseaseForOrcs;
        events.OnStarvation += orcs.starvationForOrcs;
        events.OnEnginnering += orcs.engineeringForOrcs;
      
        events.OnDisease += elves.diseaseForElves;
        events.OnStarvation += elves.starvationForElves;
        events.OnEnginnering += elves.engineeringForElves;
       
        while (isGamePlay)

        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Day: {time / deltatime}");
            orcs.populationGeneration(3);
            orcs.resGenPerDay(3);
            elves.populationGeneration(3);
            elves.resGenPerDay(3);
            time += deltatime;
            endDay++;
            Thread.Sleep(deltatime);
            
            switch (rndEventGen())
            {
                case 1:
                    events.OnDiseaseFunc();
                    break;
                case 4:
                    events.OnStarvationFunc();
                    break;
                case 9:
                    events.OnEnginneringFunc();
                    break;

            }
            if (endDay == 60)
            {
                isGamePlay = false;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Existing of the Earth has come to the end");
                Console.ReadKey();
            }
            if (elves.CurrentPopulation >= 5000 || elves.Food <= 50)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Elves attack Orcs");
                War(elves, orcs);
            }

            else if (orcs.CurrentPopulation >= 5000 || orcs.Food <= 50)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Orcs attack Elves");
                War(elves, orcs);
            }
            else { 
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Peace life");
            }
        }

        void War(Civilization c1, Civilization c2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("War!");
            int c1Attack = c1.AttackPower;
            int c2Defense = c2.Defense;      
            int c1Damage = c1Attack - c2Defense;
            if (c1Damage < 0) c1Damage = 0;
            c2.CurrentPopulation -= c1Damage;

            int c2Attack = c2.AttackPower;
            int c1Defense = c1.Defense;
            int c2Damage = c2Attack - c1Defense;
            if (c2Damage < 0) c2Damage = 0;
            c1.CurrentPopulation -= c2Damage;
            if (c1.CurrentPopulation == 0)
            {
                Console.WriteLine($"population of Elves is {c1.CurrentPopulation}");
                Console.WriteLine("Elves lose, Orcs won");
                isGamePlay = false;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Game Over");
            }
            else if (c2.CurrentPopulation == 0)
            {
                Console.WriteLine($"population of Orcs is {c2.CurrentPopulation}");
                Console.WriteLine("Orcs lose, Elves won");
                isGamePlay = false;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Game Over");
            }
          
        }
    }


}