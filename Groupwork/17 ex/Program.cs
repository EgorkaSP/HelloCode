Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
if (first == second*second || second == first*first)
{
    Console.WriteLine("является");
}
else {
    Console.WriteLine("не является");
}
