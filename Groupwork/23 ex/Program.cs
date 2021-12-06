// 23. Показать таблицу квадратов чисел от 1 до N 

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица квадратов чисел: ");
for (int count = 1; count <= N; count++)
{
 Console.WriteLine($"Квадрат числа {count} равно {count*count} ");
}
