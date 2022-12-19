using System.Drawing;

internal class Program
{
    private static int time = 1000;
    private static int deltatime = 1000;
    private static bool isGamePlay = true;
    private static void Main(string[] args)
    {
        static int rndEventGen()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 10);
            return i;
        }
        while (isGamePlay)

        {
            Console.WriteLine($"Day: {time / deltatime} , {rndEventGen()}");
            time += deltatime;
            Thread.Sleep(deltatime);
            rndEventGen();
        }

        Thread threadOfAvari = new Thread(() =>
          {
              while (isGamePlay)
              {
                 
              }
          });
        threadOfAvari.Start();
    }
}