// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();

int[] array = new int [5];
int summa = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + ", ");
    if (i % 2 != 0)
    {
        summa = summa + array[i];
    }
}
Console.Write($" cуммa чисел одномерного массива стоящих на нечетной позиции = {summa}");