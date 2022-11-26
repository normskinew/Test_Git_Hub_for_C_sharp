using Enumerators.Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        EdissonLamp edissonLamp = new EdissonLamp();
        edissonLamp.SetIsLightOnOFF(false);
        edissonLamp.SetBrightness(1002f);
        edissonLamp.type = Lamps.weak;
        edissonLamp.StatusChecker();
    }
}