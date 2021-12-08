// 29. Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int multiple = 1;
for (int i = 1; i <= N; i++)
{
    multiple = multiple * i;
}
 Console.WriteLine($"{multiple}");