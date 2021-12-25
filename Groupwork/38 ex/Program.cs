// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
int sumNechet = 0;
int sumChet = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) sumNechet = sumNechet + array[i];
    else sumChet = sumChet + array[i];
}
Console.WriteLine("Сумма нечетных чисел: "+ sumNechet);
Console.WriteLine("Сумма четных чисел: "+ sumChet);