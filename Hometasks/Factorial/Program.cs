using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        int N = 4;
        int factorial = 1;

        Console.Write($"Факториал числа: {N}! = ");

        do
        {
           
            factorial = factorial * N;
            N = N - 1;
        }
        while (N > 0);

        Console.WriteLine(factorial);

        // Delay.
        Console.ReadKey();
    }
}