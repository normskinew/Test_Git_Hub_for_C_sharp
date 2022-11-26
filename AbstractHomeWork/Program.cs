using AbstractHomeWork;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private static void Main(string[] args)
    {
        Client client = new Client("Max", "Osadchyi", "Mono");
        client.InfoDisplay();
        BankWorker bankWorker = new BankWorker("Tan", "Kaz", "Privat");
        bankWorker.InfoDisplay();
    }
}