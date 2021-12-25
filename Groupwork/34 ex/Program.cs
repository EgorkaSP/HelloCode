// 34. Написать программу замену элементов массива на противоположные
void FillArray(int[] arr)
{
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = new Random().Next(-9,10);
    }
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");
    }
}
void ChangeElements(int[] coll)
{
    for (int j = 0; j < coll.Length; j++)
    {
        System.Console.Write($"{-coll[j]} ");
    }
}
int[] array = new int [10];
FillArray(array);
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.Write("Массив с противоположными элементами: ");
ChangeElements(array);
Console.WriteLine();

