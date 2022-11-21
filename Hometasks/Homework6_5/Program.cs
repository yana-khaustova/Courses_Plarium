using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

static string Method (int number)
{
    bool prost = true;
    string res = string.Empty;
    for (int i = 2; i < number/2; i++)
    {
        if (number % i == 0)
        {
            prost = false;
            break;
        }
    }
    if (prost)
    {
        Console.WriteLine("Число простое");
    }
    else
    {
        Console.WriteLine("Число не простое");
    }
    return res;
}

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
string sentence = Method(number);
Console.WriteLine(sentence);