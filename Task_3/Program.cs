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
int max = 1;
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
if (array[i] > max)
{
max = array[i];
}
else if(array[i] <= min)
{
    min = array[i];
}
}

return max - min;
}
int[] array = RandomArray(5);

Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine(Sum(array));