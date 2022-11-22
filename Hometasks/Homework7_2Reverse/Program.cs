using System;

static int[] MyReverse(int[] array)
{
    int N = 0;
    Random r = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = r.Next(10, 200);

    }


    int[] reversedArray = new int[array.Length];
    int j = 0;
    for (int i = reversedArray.Length - 1; i >= 0; i--)
    {
        reversedArray[j++] = array[i];
    }
    return reversedArray;

}

Console.WriteLine("Enter number");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int[] reversedArray = MyReverse(array);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]}");
}
Console.WriteLine();
for (int i = 0; i < reversedArray.Length; i++)
{
    Console.WriteLine($"{reversedArray[i]}");
}
