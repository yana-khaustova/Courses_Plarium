using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        int number;
        Console.Write("Enter number:");
        number = Convert.ToInt32(Console.ReadLine());

        if (number >= 0 && number <= 14)
        {

            Console.WriteLine("Промежуток 1");
        }
        else if (number >= 15 && number <= 35)
        {
            Console.WriteLine("Промежуток 2");
        }
        else if (number >= 36 && number <= 50)
        {
            Console.WriteLine("Промежуток 3");
        }
        else if (number >= 50 && number <= 100)
        {
            Console.WriteLine("Промежуток 4");
        }
        else
        {
            Console.WriteLine("Не существует такого промежутка");
        }

    }

}