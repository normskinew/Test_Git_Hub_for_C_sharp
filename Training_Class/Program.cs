using Training_Class;

internal class Program
{
    private static void Main(string[] args)
    {
        Owners car1 = new Owners ("Max",1900,"Green","Skoda",150);
        Car car = new Owners("Andryi",2200, "Red", "Ford", 200);
        Car skoda = new Car();
        Car car2 = new Owners();
        Car.Engine speed_1 = new Car.Engine();
        speed_1.IsStarted(true);
        speed_1.GetRotateSpeed();
       

        car1.PrintAll();
        car.PrintAll();
        Owners.CountFunc();
        Console.ReadKey();
    }
}