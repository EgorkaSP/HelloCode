//  5. Написать программу вычисления значения функции y = f(a)
/*
y = x-1, x>=0
y = |x|, x<0
*/
int x = Convert.ToInt32(Console.ReadLine());
if (x>=0)
{
    Console.WriteLine(x-1);
}
else if (x<0)
{
    Console.WriteLine(Math.Abs(x));
}