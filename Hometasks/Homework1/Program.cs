using System.Text;
internal class Program
{

    
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        string name;
        Console.WriteLine("введите свое имя");
        name = Console.ReadLine();
        Console.WriteLine("Привет " + name);
    }
}