using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        //Home_Work_6_task_1

        Console.Title = "Work";
        Random random = new Random();
        int[] salary = new int[5];
        for (int i = 0; i < salary.Length; i++)
        {
            
            salary[i] = random.Next(6500, 100000);
            
        }
        
        string[] surname = new string[] { "Oleg", "Igor", "Maria", "Tanya", "Max" };
        for (int i = 0; i < surname.Length; i++)
        {
            
            Console.WriteLine($"The salary of {surname[i]} is {salary[i]}");
        }



        Console.ReadKey();

    }
}