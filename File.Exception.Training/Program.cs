using System.Text;

internal class Program
{
    private static void Main(string[] args)
        //Class_work File.FileStream.StreamWriter/Reader.Exception.

    {//Робота із класом File , простий спосіб , однопотоковий.
        //string fileName = @"text.txt";
        //File.WriteAllText(fileName, "Hello World\nHello Hello");
        //foreach(string file in File.ReadLines(fileName))
        //    Console.WriteLine(file);

        //Робота із класом FileStream, запис текстру у байти, і назад із байтів у стрінг.Перевага - потоковий процес. Мінус - багато писати коду.
        //string fileName2 = @"text2.txt";
        //string words = "Add some words";
        //FileStream fileStream = File.Open(fileName2,FileMode.Create);
        //byte[] writeToByte = Encoding.Default.GetBytes(words);
        //fileStream.Write(writeToByte, 0, writeToByte.Length);
        //fileStream.Position = 0;
        //byte[] readToByte = new byte[writeToByte.Length];
        //for(int i = 0; i < writeToByte.Length; i++)
        //{
        //    readToByte[i] = (byte)fileStream.ReadByte();
        //}
        //Console.WriteLine(Encoding.Default.GetString(readToByte));
        //fileStream.Close();

        //Робота із класом StreamWriter/Reader.Багатопотоковий процес.Зрозумілий простий код.
        //string file_name = @"streamReader.txt";
        //string words = "Training Stream Writer/Reader";
        //StreamWriter streamWriter = File.CreateText(file_name);
        //streamWriter.WriteLine(words);
        //streamWriter.WriteLine("I added new text very easy");
        //streamWriter.Close();
        //StreamReader streamReader = File.OpenText(file_name);
        //Console.WriteLine(streamReader.ReadToEnd());
        //streamReader.Close();
        byte number = 0;
        bool isWork = false;
        int[] box = { 0, 1, 2 };
      
        Console.WriteLine("Enter number from 0 to 255 , type is Byte");
        do
        {
            try
            {
              
                number = Convert.ToByte(Console.ReadLine());
                isWork = false;
                Console.WriteLine("Right!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format, try again");
                isWork = true;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("No exists number in array, try again");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Incorrect number, try again");
                isWork = true;
            }
            finally {}
        }
        while (isWork == true);


    }
}