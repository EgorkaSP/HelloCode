//  8. Показать четные числа от 1 до N

int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <=N)
{
if(count%2==0 )
{
    Console.WriteLine(count);
}
count++;
}