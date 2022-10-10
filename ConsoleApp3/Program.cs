internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Home_Work_6_task_1";
        Console.ForegroundColor = ConsoleColor.Green;
        int[] salary = new int[5];
        string[] surname = new string[] { "Oleg", "Igor", "Maria", "Tanya", "Max" };
        Random random = new Random();
        for (int i = 0; i < surname.Length; i++)
        {
            Console.WriteLine(surname[i] + ": "+random.Next(6500,100000));
        }

        Console.ReadKey();

    }
}