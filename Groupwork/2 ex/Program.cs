﻿﻿//  2. Даны два числа. Показать большее и меньшее число

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}
else if (b > a)
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);

}
else if (a == b)
{
    Console.WriteLine("Числа равны");
}


// void MaxMin(int x, int y)
// {
//     if (x > y)
//     {
//         Console.WriteLine("max = " + x);
//         Console.WriteLine("min = " + y);
//     }
//     if (y > x)
//     {
//         Console.WriteLine("max = " + y);
//         Console.WriteLine("min = " + x);
//     } 
// }
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// MaxMin(a,b);

