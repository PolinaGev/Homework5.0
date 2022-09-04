int[] RandomArray(int size)
{
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100, 1000);
}

return array;
}

int FindAmount(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
{
count++;
}
}

return count;
}

int[] array = RandomArray(5);

Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine(FindAmount(array));