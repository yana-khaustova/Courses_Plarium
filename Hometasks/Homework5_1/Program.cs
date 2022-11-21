using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        int A = 10;
        int B = 20;
        int sum = 0;
        for (int i = A; B >= i; i++)
            sum += i;
        Console.WriteLine("Сумма чисел в заданном интервале равна:" + sum);
        Console.ReadLine();
    }
}