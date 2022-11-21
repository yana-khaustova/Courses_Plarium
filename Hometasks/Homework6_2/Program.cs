
using System.Xml.Linq;

static double Convertor(int money, double ExchangeRates)
{
    return (money * ExchangeRates);
}

Console.WriteLine("Enter money");
int money = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Exchange Rates");
double ExchangeRates = Convert.ToDouble(Console.ReadLine());
double result = Convertor(money, ExchangeRates);
Console.WriteLine("Result = " + result);
