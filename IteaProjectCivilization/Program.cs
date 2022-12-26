using IteaProjectCivilization;
using System.Drawing;

internal class Program
{
    private static int time = 1000;
    private static int deltatime = 1000;
    private static bool isGamePlay = true;
    private static int endDay;
    private static void Main(string[] args)
    {
         int rndEventGen()
         {
            Random rnd = new Random();
            int i = rnd.Next(0, 10);
            return i;
         }
        Events events = new Events();
        Elves elves = new Elves();
        events.OnDisease += elves.diseaseForElves;
        events.OnStarvation += elves.starvationForElves;
        
        while (isGamePlay)

        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Day: {time / deltatime}");
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

            }
            if(endDay == 60)
            {
                isGamePlay = false;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Game Over");
                
            }
            
        }

        Thread threadOfElves = new Thread(() =>
          {

          });
        threadOfElves.Start();
    }


}