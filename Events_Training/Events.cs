using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Training;

internal class Events
{       //створюємо клас івент класичний + по бажанню розширюємо його аргументи дженерік класом 
    public event EventHandler<AdditionalArgs> OnMyEvent;
    private int counter;
    //завжди для запуску івенту треба юзати метод підйому івенту
    public void OnMyEventMethod()
    {
        counter++;
        OnMyEvent?.Invoke(this, new AdditionalArgs { counter = counter});
        OnMeEventViaDelegate?.Invoke(44.4f);
        OnMyEventViaAction?.Invoke(10, false, "Action Event");
    }
    //метод , що підписався на івент і відповідно викликався , коли викликався івент
    public static void HandleMyEvent(object sender, AdditionalArgs e)
    {
        Console.WriteLine($"Called an Event via EventHandler {e.counter} time");
    }
    public static void MyClass_OnMeEventViaDelegate(float f)
    {
        Console.WriteLine($"This events has benn called via Delegate system - {f}");
    }
    public static void MyClass_OnMyEventViaAction(int arg1, bool arg2, string arg3)
    {
        Console.WriteLine($"Called via Action class {arg1}, {arg2}, {arg3}");
    }
    //клас , що внаслідує івентові аргументи ,  щоб потім вписатися дженеріком і розширити функціонал івенту
    public class AdditionalArgs : EventArgs
    {
        public int counter;
    }
    //створити івент через делегат
    public delegate void CreateEventViaDelegate(float f);
    public event CreateEventViaDelegate OnMeEventViaDelegate;

    //створити івент через клас Екшен , що по природі має воід делегат і в який можна вставити багато типів даних як параметри
    public event Action<int, bool, string> OnMyEventViaAction;

}
