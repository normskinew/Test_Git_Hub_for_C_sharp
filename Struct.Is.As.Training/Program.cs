using Struct.Is.As.Training;

internal class Program
{
    private static void Main(string[] args)
    {//Робота із структурою - це маленький клас для суб об"Єктів основного класу. Is - перевірка на належність до класу.As -приведення до типу певного об"єкта(копіювання)
        Book book1 = new Book("Lord of the Rings",1000,1962,"Tolkien");
        Book book2 = new Book("Rich Dad", 250, 1985, "lol");
        User first = new User("Max", 14, book1);
        User second = new Admin("Serg", 50, book2, "Admin");
        List<User> users = new List<User>();
        users.Add(first);
        users.Add(second);
        foreach(User user in users)
        {
            //Admin adm = user as Admin;
            if (user as Admin != null)
            {
                second.WholeInformation();
                second.Book.printInfoAboutBook();
            }
            
        }
        
    }
}