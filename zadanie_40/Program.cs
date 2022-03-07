// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();

double[] array = new double [5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + ", ");
}

double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    max = array[i];
    if (array[i] < min)
    min = array[i];
}
Console.Write($" разница между максимальным и минимальным элементом = {max} - {min} = {max - min}");
