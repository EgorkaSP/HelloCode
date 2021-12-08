// 30. Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()); 
for (int i = 1; i <= N; i++)
{
    int result = i*i*i;
    if(result % 2 == 0) Console.WriteLine($"{i}^3 = {result}");
}