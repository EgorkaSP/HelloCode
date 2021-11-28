//  1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите два числа: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x*x==y)
{
Console.WriteLine("x является квадратом числа y");
}
else 
{
Console.WriteLine("x не является квадратом числа y");
}