// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.Clear();

int[] array = new int [30];
int honest = 0;
int odd = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + ",\t");
    if (array[i] % 2 == 0)
    {
        honest = honest + 1;
    }
    else 
    {
        odd = odd + 1;
    }
}
Console.WriteLine($"\n Колличество четных = {honest} \t Колличество нечетных = {odd}");
