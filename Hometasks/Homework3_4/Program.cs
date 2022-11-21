internal class Program
{
    private static void Main(string[] args)
    {
        const double pi = 3.14;
        double r = 6;
        double h = 10.5;
        double V = (pi * r * 2 * h);
        double S = (2 * pi * r * (r + h));

        Console.WriteLine("Volume is " + V);
        Console.WriteLine("Surface area is " + S);


    }
}