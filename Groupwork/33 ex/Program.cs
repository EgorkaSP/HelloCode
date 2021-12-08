// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-9, 10);
    }
}
void PrintArray(int[] coll)
{
    for (int j = 0; j < coll.Length; j++)
    {
        Console.Write($"{coll[j]} ");
    }
}
int[] array = new int[12];
FillArray(array);
PrintArray(array);
int sum1 = 0;
int sum2 = 0;
for (int k = 0; k < array.Length; k++)
{
    if (array[k] > 0)
    {
        sum1 = sum1 + array[k];
    }
    else sum2 = sum2 + array[k];
}

System.Console.WriteLine();
Console.WriteLine($"{sum1} {sum2}");