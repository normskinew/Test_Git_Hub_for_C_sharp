using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        //Home_Work_6_task_1

        Console.Title = "Work";
        Random random = new Random();
        Console.WriteLine("Press enter to start");
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        int[] salary = new int[5];
        for (int i = 0; i < salary.Length; i++)
        {

            salary[i] = random.Next(6500, 100000);

        }

        string[] surname = new string[] { "Oleg", "Igor", "Maria", "Tanya", "Max" };
        for (int i = 0; i < surname.Length; i++)


            Console.WriteLine($"The salary of {surname[i]} is {salary[i]}");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Press enter to follow next program");
        Console.ReadLine();
        //Home_Work_6_task_2
        Console.Title = "Vanicle";
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        string[] name = new string[1];
        string[] car = new string[1];
        int[] year = new int[1];
        string[] number = new string[1];
        
        
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine("Enter name and surname of the car's owner");
            name[i] = Console.ReadLine();
            Console.WriteLine("Enter model of the venicle");
            car[i] = Console.ReadLine();
            Console.WriteLine("Enter year of the manufacture");
            year[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vanicle number in special format : AA 2233 BI");
            number[i] = Console.ReadLine();
        }
        foreach(string s in name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
        }
        foreach (string s in car)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
        }
        foreach (int s in year)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
        }
        foreach (string s in number)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
        }

        Console.ReadKey();

    }
}