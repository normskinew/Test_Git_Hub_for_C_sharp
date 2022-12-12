using Events_Training;
using static Events_Training.Events;

internal class Program
{
    private static void Main(string[] args)
    {//об"єкт івенту
        Events myClass = new Events();
        //звертання до івенту + підписка методу на цей івент
        myClass.OnMyEvent += HandleMyEvent;

        //звертання до івенту + підписка методу на цей івент
        myClass.OnMeEventViaDelegate += MyClass_OnMeEventViaDelegate;
        //звертання до івенту + підписка методу на цей івент
        myClass.OnMyEventViaAction += MyClass_OnMyEventViaAction;
        //виклик методу-хендлера івенту , що підіймає івенти
        myClass.OnMyEventMethod();
    }

    
}