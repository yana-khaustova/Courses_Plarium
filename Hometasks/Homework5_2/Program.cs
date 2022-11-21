internal class Program
{
    private static void Main(string[] args)
    {
        int min = 10;
        int max = 20;
        
       while (min < max)
        {
            if (min % 2 == 0)
            {
                min++;
            }
            Console.WriteLine(min);
            min += 2;
        }

    }
}