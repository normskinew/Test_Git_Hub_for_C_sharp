using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.Title = "Home_Work_leasson_3";
                int a, b, c;
                
                double x1 = 0, x2 = 0;

                Console.WriteLine("Enter first coefficient - a ( a != 0)");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second coefficient - b");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter third coefficient - c");
                c = Convert.ToInt32(Console.ReadLine());
                double Discriminator = Math.Pow(b, 2) - 4 * a * c;
                if (Discriminator == 0)
                {
                    x1 = x2 = -b / 2 * a;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Only one root = {x1}");
                }
                else if (Discriminator > 0)
                {
                    x1 = -b + Math.Sqrt(Discriminator) / 2 * a;
                    x2 = -b - Math.Sqrt(Discriminator) / 2 * a;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Root x1 = {x1}, root x2 = {x2}");
                }
                else if (Discriminator < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Root doesn't exist");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Want to find some new roots? Press ( y / n)");
                Console.WriteLine("");
                answer = Console.ReadLine();
                
            } while (answer == "y");

        }
    }
}
