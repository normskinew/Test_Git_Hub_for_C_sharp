using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, c;
            string answer;
            Random _randomGenerator = new Random();
            x = _randomGenerator.Next(-120, 120);
            y = _randomGenerator.Next(-120, 120);
            int[] radiusMass = new int[11] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.Title = "Home_work_4_task_(1)";
            Console.WriteLine("Hello, user! Let's play the game? \nPress (y/n) to continue");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                string ans;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Point A({x},{y}) has been generated!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("According to the Pythagorean theorem, the sum of the squares of the legs is equal to the square of the hypotenuse!\nx2 + y2 = c2;");
                    c = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Hypotenuse= {c}");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (c <= radiusMass[1] && c >= radiusMass[0])
                    {
                        Console.WriteLine("You have 10 points");
                    }
                    else if (c <= radiusMass[2] && c > radiusMass[1])
                    {
                        Console.WriteLine("You have 9 points");
                    }
                    else if (c <= radiusMass[3] && c > radiusMass[2])
                    {
                        Console.WriteLine("You have 8 points");
                    }
                    else if (c <= radiusMass[4] && c > radiusMass[3])
                    {
                        Console.WriteLine("You have 7 points");
                    }
                    else if (c <= radiusMass[5] && c > radiusMass[4])
                    {
                        Console.WriteLine("You have 6 points");
                    }
                    else if (c <= radiusMass[6] && c > radiusMass[5])
                    {
                        Console.WriteLine("You have 5 points");
                    }
                    else if (c <= radiusMass[7] && c > radiusMass[6])
                    {
                        Console.WriteLine("You have 4 points");
                    }
                    else if (c <= radiusMass[8] && c > radiusMass[7])
                    {
                        Console.WriteLine("You have 3 points");
                    }
                    else if (c <= radiusMass[9] && c > radiusMass[8])
                    {
                        Console.WriteLine("You have 2 points");
                    }
                    else if (c <= radiusMass[10] && c > radiusMass[9])
                    {
                        Console.WriteLine("You have 1 points");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have 0 points");
                    }
                    Console.WriteLine("Press (y/n) to continue");

                } while (ans == "y");



                Console.ReadKey();
            }

            else if (answer == "n")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Bye-bye\nYou will close the program without knowing what I had in mind...");
                Console.ReadKey();
            }
        }
    }
}
