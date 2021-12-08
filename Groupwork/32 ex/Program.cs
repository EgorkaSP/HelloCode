// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] coll)
{
    for (int j = 0; j < coll.Length; j++)
    {
        System.Console.Write($"{coll[j]} ");
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);