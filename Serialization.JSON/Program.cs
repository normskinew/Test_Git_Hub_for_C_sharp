using Serialization.JSON;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Серіалізація даних у дат бінарі файл ( у бінарний код), потім десереалізація.
        Animals cat = new Animals(15, "Lucky");
        Animals dog = new Animals(5, "Tiff");
        Animals[] animals = new Animals[] { cat, dog };
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        using (FileStream fs = new FileStream("Animals.dat", FileMode.OpenOrCreate))
        {
            binaryFormatter.Serialize(fs, animals);
            Console.WriteLine("Serialization has been done");
            fs.Close();

        }
        using (FileStream fs = new FileStream("Animals.dat", FileMode.OpenOrCreate))
        {
            Animals[] animals_2 = (Animals[])binaryFormatter.Deserialize(fs);

            Console.WriteLine("Deserialization has been done");
            foreach (Animals animal in animals_2)
            {
                Console.WriteLine($"Name is {animal.name}, age is {animal.age}");
            }
            fs.Close();

        }
        #endregion
        #region Серіалізація даних у ХМЛ файл, потім десереалізація.
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Animals[]));
        using (FileStream fs = new FileStream("Animals.xml", FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(fs, animals);
            Console.WriteLine("Serialization XML has been done");
            fs.Close();

        }
        using (FileStream fs = new FileStream("Animals.xml", FileMode.OpenOrCreate))
        {
            Animals[] animals_2 = (Animals[])xmlSerializer.Deserialize(fs);

            Console.WriteLine("Deserialization XML has been done");
            foreach (Animals animal in animals_2)
            {
                Console.WriteLine($"Name is {animal.name}, age is {animal.age}");
            }
            fs.Close();
        }
        #endregion
    }
}