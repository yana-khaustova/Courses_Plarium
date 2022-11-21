using System.Text;
using System.Xml.Linq;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

static string Method(int number)
{
    string res = string.Empty;

    if (number < 0)
    {
        res = "Отрицательное число";
    }
    else
    {
        res = "Положительное число";
    }

    return res;
}

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
string sentence = Method(number);
Console.WriteLine(sentence);