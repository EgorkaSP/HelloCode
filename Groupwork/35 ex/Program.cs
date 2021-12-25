// 35. Определить, присутствует ли в заданном массиве, некоторое число

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");

    }
}
Console.Write("Введите искомое число: ");
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
PrintArray(array);
Console.WriteLine();
int find = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == find) Console.WriteLine($"Число {find} присутствует в массиве");
    else
    {
        Console.WriteLine("Такого числа нет");
    }
}