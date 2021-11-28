Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

int count = -N; 
while (count <= N)
{
    Console.WriteLine(count);
    count++;
}
