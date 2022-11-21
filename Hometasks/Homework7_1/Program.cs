

Console.WriteLine("Enter number");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];


Random r = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(10, 20);
   
}
// Вывод на экран значений элементов массива.
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

int max = int.MinValue;
for (int i = array.Length - 1; i >= 0; i--)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine("Max value is " + max);

int min = int.MaxValue;
for (int i = array.Length - 1; i >= 0; i--)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine("Min value is " + min);

int Sum = 0;
for (int i = 0; i < N; i++)
{
    Sum += array[i];
}
Console.WriteLine("Sum is " + Sum);

float average = Sum / N;
Console.WriteLine("The average is " + average);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
        Console.Write(array[i] + " ");
    }
}


// Delay.
Console.ReadKey();
