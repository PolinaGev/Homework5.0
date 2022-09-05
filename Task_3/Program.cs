double[] RandomArray(int size)
{
double[] array = new double[size];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(100)/10.0;
}

return array;
}

double Sum(double[] array)
{
double max = 1;
double min = array[0];
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
double[] array = RandomArray(5);

Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine(Sum(array));
