// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void FillArray(int[] collection)
{
    for (int k = 0; k < collection.Length; k++)
    {
        collection[k] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] coll)
{
    for (int j = 0; j < coll.Length; j++)
    {
        Console.Write($"{coll[j]} ");
    }
}
int[] array = new int[10];
int chet = 0;
int nechet = 0;
FillArray(array);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) chet = chet + 1;
    else nechet = nechet = nechet + 1;
}
Console.WriteLine("Количество четных чисел: " + chet);
Console.WriteLine("Количество нечетных чисел: " + nechet);
