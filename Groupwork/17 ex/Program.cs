// 17. По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
if (first == second*second || second == first*first)
{
    Console.WriteLine("является");
}
else {
    Console.WriteLine("не является");
}
