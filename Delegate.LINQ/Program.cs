
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

internal class Program
{
    #region Делегати - показчики на методи.Як юзати.
    //delegate void TimeCheker();
    //delegate int Math(int x, int y);
    //private static void Main(string[] args)
    //{
    //    TimeCheker timeCheker;
    //    Math math;

    //    if(DateTime.Now.Hour < 14)
    //    {
    //       timeCheker = Day;
    //        math = Sum;
    //        Console.WriteLine(math);
    //    }
    //    else
    //    {
    //        timeCheker = Night;
    //        math = Mult;

    //    }
    //    timeCheker();
    //    Console.WriteLine(math(4, 4));
    //}

    //private static int Mult(int x, int y)
    //{
    //    return x * y;
    //}

    //private static int Sum(int x, int y)
    //{
    //    return x + y;
    //}

    //private static void Night()
    //{
    //    Console.WriteLine("It's a night time");       
    //}

    //private static void Day()
    //{
    //    Console.WriteLine("It's a Day time");
    //}
    #endregion
    #region Lambda func - записування методів коротко, в 1 лінію.Методи, які додають масиви, змінні.
    //delegate float Calcul(float x);
    //private static void Main(string[] args)
    //{
    //     Calcul calcul = c => c * c;
    //    // Console.WriteLine(calcul(10));
    //List<int> list = new List<int>();
    //list.AddRange(Enumerable.Range(0, 100));
    //List<int> list_2 = new List<int>();
    //list_2.AddRange(Enumerable.Range(100, 200));
    //var stackArrays = list.Zip(list_2, (x, y) => x * y);        //Zip метод, що сумує 2 масиви, щоб виконати дії спільно, пр:перемножити елементи {l1*l2 each}
    //foreach(var el in stackArrays)
    //{
    //    Console.WriteLine(el);
    //}
    //List<string> list_3 = new List<string>() {"ABC","ABC","QWE","ZXC"};
    //string joinPrac = string.Join(", ", list);           //Jojn метод об"єднує елементи певного масиву і приводить до стрінги
    //Console.WriteLine(joinPrac);
    //joinPrac = string.Join(", ", list_3.Distinct());     // Join + arrray Disting метод , що виводить із масиву не повторювальні елементи , пр.АВС вивело 1 раз.
    //Console.WriteLine(joinPrac);
    //Random rand = new Random();
    //for(int i = 0; i < 10; i++)
    //{
    //    list.Add(rand.Next(1,10));
    //}
    //var listNew = list.Where(i => (i>=4) && (i <=8)).ToList().Count();            //Where LINQ (вибрати щось)
    //Console.WriteLine(listNew);
    //list.AddRange(Enumerable.Range(1,10));
    //int agro_1 = list.Aggregate((x, y) => x + y);         //Aggregate метод - працює із 2-ма числами x,y
    //Console.WriteLine(agro_1);
    //var listNEW = list.Select(x => x * x);            // Select LINQ (вибрати кожен елемент і щось зробити з ним)
    //int agro_2 = listNEW.Aggregate((x, y) => x + y);      //Aggregate метод - працює із 2-ма числами x,y
    //Console.WriteLine(agro_2);
    //foreach (int i in listNEW)
    //{
    //    Console.WriteLine(i);
    //}
    //}
    #endregion
    #region Домашнє завдання по даній темі
    delegate void Del(params int[] ints);
    private static void Main(string[] args)
    {
      

        Del del = Sum;
        del += Avrg;
        del(5,3,13);
        
        
        
        static void Sum(params int[] ints)
        {
            int s = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                s += ints[i];
            }
            Console.WriteLine(s);
        }
        static void Avrg(params int[] ints)
        {
            int s = 0;
            int t = 0;
            for(int i = 0; i < ints.Length; i++)
            {
                s += ints[i];
               
            }
            t = s / ints.Length;
            Console.WriteLine(t);
        }
        string[] countries = { "США", "Канада", "Франция", "Лондон", "Барселона" };

        var specStart = countries.Where(c => c.ToUpper().StartsWith("Б"));
        foreach(string i in specStart)
        {
            Console.WriteLine(i);   
        }






    }

    #endregion
}