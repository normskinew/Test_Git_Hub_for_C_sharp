using System.Security.Cryptography.X509Certificates;
using Threading.MultiThreading;

internal class Program
{
    //static int count;
    //static object locker = new object();
   
    private static void Main(string[] args)
    {

        #region Робота із головним потоком
        //Thread thread = Thread.CurrentThread;
        //Console.WriteLine(thread.Priority);
        //Console.WriteLine(thread.ThreadState);
        //Console.WriteLine(thread.IsAlive);
        //thread.Name = "firts";
        //Console.WriteLine(thread.Name);
        //Console.WriteLine(Thread.GetDomain().FriendlyName);
        #endregion.
        #region Робота із власним потоком(1), що є паралельний до основного потоку.
        //Numbers numbers = new Numbers(5, 10);
        //Thread tr = new Thread(new ThreadStart(numbers.GetCurSituation));
        //tr.Start();
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("Main thread");
        //    Thread.Sleep(300);
        //}
        #endregion
        #region Робота із багатьма власними потоками.
        //for (int i = 1; i < 7; i++)
        //{
        //    Thread thread = new Thread(new ThreadStart(CustomFuncForThreading));
        //    thread.Name = "Name is " + i.ToString();
        //    thread.Start();

        //}

        //static void CustomFuncForThreading()
        //{
        //    lock (locker)
        //    {
        //        count = 1;
        //        for (int i = 0; i < 5; i++)
        //        { 

        //            Console.WriteLine($"{Thread.CurrentThread.Name}: {count}");
        //            count++;
        //            Thread.Sleep(500);
        //        }
        //    }
        #endregion
        #region Home_WORK
       // Thread threadNEW = new Thread(new ThreadStart(ThreadFunc));
       //threadNEW.Start();

       // for(int i = 0; i <10; i++)
       // {
       //     Console.WriteLine("MAIN");
       //     Thread.Sleep(500);
       // }

       // static void ThreadFunc()

       // {   for(int i = 0; i < 10; i++)
       //     {
       //         Console.WriteLine($"Some number , and some number ");
       //         Thread.Sleep(500);
       //     }

       // }
        #endregion
    }
}