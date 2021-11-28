Console.WriteLine("Введите два числа: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if(x>y) 
{
    max=x; 
    min=y;
}
else
 {
max=y;
min=x;
}
Console.Write("Max= ");
Console.WriteLine(max);
Console.Write("Min= ");
Console.WriteLine(min);