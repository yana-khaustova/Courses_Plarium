using System.Xml.Linq;


static double Add(int number1, int number2)
{
    return number1 + number2;

}
static double Sub(int number1, int number2)
{
    return number1 - number2;

}
static double Mul(int number1, int number2)
{
    return number1 * number2;

}

static double Div(int number1, int number2)
{
    if (number2 == 0)
    {
        Console.WriteLine("Divisible number2 cannot be zero");
        return 0;
    }
    else
    {
        return number1 / number2;
    }

}



Console.WriteLine("Enter number_1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number_2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter operator");
string sign = Console.ReadLine();

double result = 0;
switch (sign)
{

    case "+":
         result = Add(number1, number2);
        break;
    case "-":
         result = Sub(number1, number2);
        break;
    case "*":
         result = Mul(number1, number2);
        break;
    case "/":
         result = Div(number1, number2);
        break;
     

}
Console.WriteLine("Result = " +result);



Console.ReadKey();




