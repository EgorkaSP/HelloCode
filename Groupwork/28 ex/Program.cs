// 28. Подсчитать сумму цифр в числе

int Number = Convert.ToInt32(Console.ReadLine());
int count = Number.ToString().Length;
int Sum = 0;
int Digit = 0;
for (int i = 0; i <= count; i++)
{
    Digit = Number % 10;
    Number = Number / 10;
    Sum = Sum + Digit;
}
Console.WriteLine(Sum);

