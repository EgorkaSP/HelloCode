// 31. Задать массив из 8 элементов и вывести их на экран
void FillArray(int[] coll)
{
    for (int j = 0; j < coll.Length; j++)
    {
        coll[j] = new Random().Next(1,8);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");
    }
}


int[] array = new int[8];
FillArray(array);
PrintArray(array);

