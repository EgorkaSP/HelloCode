// 4. Найти максимальное из трех чисел

Console.Write("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
{
    Console.WriteLine("Максимальное число: " + FirstNumber);
}
else if (SecondNumber > FirstNumber && SecondNumber > ThirdNumber)
{
    Console.WriteLine("Максимальное число: " + SecondNumber);
}
else if (ThirdNumber > FirstNumber && ThirdNumber > SecondNumber)
{
    Console.WriteLine("Максимальное число: " + ThirdNumber);
}


