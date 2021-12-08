// 26. Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
for (int b = 1; b <= 10; b++)
{ int res = Convert.ToInt32(Math.Pow(A,b));
Console.WriteLine($"{A}^{b} = {res}");
Console.WriteLine();
}