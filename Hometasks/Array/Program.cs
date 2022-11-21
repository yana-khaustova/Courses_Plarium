

int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1,100 };
int max = int.MinValue;
for (int i = array.Length - 1; i>= 0; i--)
{
	if (array[i] > max)
	{
		max = array[i];
	}
}
Console.WriteLine(max);



