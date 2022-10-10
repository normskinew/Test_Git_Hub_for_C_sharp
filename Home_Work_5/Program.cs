using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Home_Work_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Temperature_Convertor";
            string answer;

            Console.WriteLine("This program provide convertation of temp degrees : Kelvin, Celsium, FahrenHait");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("To convert Celsuim to Kelvin , press - 1\nTo convert Kelvin to Celsium , press - 2");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("To convert Celsuim to Fahrenhait , press - 3\nTo convert Fahrenhait to Celsium , press - 4");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("To convert Kelvin to Fahrenhait , press - 5\nTo convert Fahrenhait to Kelvin , press - 6");
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.WriteLine("Choose convertor type:");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter degree");
                        double ctk = double.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Green;
                        Temperature.KelvinFromCel(ctk);
                        break;
                    case 2:
                        Console.WriteLine("Enter degree");
                        double ktc = double.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Green;
                        Temperature.CelsiumFromKel(ktc);
                        break;
                    case 3:
                        Console.WriteLine("Enter degree");
                        double ctf = double.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Temperature.FarenhaitFromCel(ctf);
                        break;
                    case 4:
                        Console.WriteLine("Enter degree");
                        double ftc = double.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Temperature.CelsiumFromFar(ftc);
                        break;
                    case 5:
                        Console.WriteLine("Enter degree");
                        double ktf = double.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Temperature.FarenheitFromKel(ktf);
                        break;
                    case 6:
                        Console.WriteLine("Enter degree");
                        double ftk = double.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Temperature.KelvinFromFar(ftk);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrent input, choose number from 1 to 6");
                        break;

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to convert some degree again?\nPrint (yes/no) to continue");
                answer = Console.ReadLine();

            } while (answer == "yes");


            /* 
                Console.Title = "Factorial";
                Console.WriteLine("Enter number");
                long n = long.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Factorial is " + recFunk(n));
                Console.ReadKey();
            
             static long recFunk(long n)
             {
                if (n == 0)
                    return 1;
                else
                    return recFunk(n - 1) * n;

             }

            */





        }


    }
}
