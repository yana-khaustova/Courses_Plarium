internal class Program
{
    private static void Main(string[] args)
    {
        int height = 20;
        int width = 20;
        for (int row = 0; row < width; row++)
        {
            for (int column = 0; column < height; column++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
        Console.ReadLine(); 
    }
}