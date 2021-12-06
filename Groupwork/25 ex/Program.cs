// 25. Найти сумму чисел от 1 до А

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
for (int count = 1; count <= N; count++)
{
    Sum = Sum + count;
}
Console.WriteLine(Sum);