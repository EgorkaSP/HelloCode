//  7. Показать числа от -N до N

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = -N; 
while (count <= N)
{
    Console.WriteLine(count);
    count++;
}
