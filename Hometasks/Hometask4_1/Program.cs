internal class Program
{
    private static void Main(string[] args)
    {
        int operand1 = 5;
        int operand2 = 19;
        float result = 0;
        Console.WriteLine("Enter operator");
        string sign = Console.ReadLine();
        switch (sign)
        {

            case "+":
                result = operand1 + operand2;
                break;
            case "-":
                result = operand1 - operand2;
                break;
            case "*":
                result = operand1 * operand2;
                break;
            case "/":
                result = operand1 / operand2;
                break;
            case "%":
                result = operand1 % operand2;
                break;



        }
        Console.WriteLine("Result = " + result);
    }
}