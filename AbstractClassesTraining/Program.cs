using AbstractClassesTraining;

internal class Program
{
    private static void Main(string[] args)
    {// Абстрактні класи та їх методи , що обов"язкові до реалізації, віртуальні методи для переписування в наслідниках.
        //Абстракти потрібні щоб задавати функціонал і далі наслідниками розширюватися
        Humans Max = new People();
        Humans Alient = new UFO();
        Max.Doing();
        Alient.Doing();
        Max.talk();
        Max.walk();
        Alient.talk();
        Alient.walk();
        TypeTrain<int,string> typeTrain = new TypeTrain<int,string>(23,"COOL");
        
        
    }
}