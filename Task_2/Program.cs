int[] RandomArray(int size)
{
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100);
}

return array;
}

int Sum(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if (i % 2 != 0)
{
sum = sum +array[i];
}
}

return sum;
}

int[] array = RandomArray(10);

Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine(Sum(array));