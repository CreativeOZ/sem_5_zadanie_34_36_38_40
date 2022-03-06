// 34. Написать программу замену элементов массива на противоположные

Console.Clear();

int[] array = {8, 7, 6, -5, -4, 3, 0};
Console.Write("Противоположные элементы:\t");
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i] + ",\t");
}