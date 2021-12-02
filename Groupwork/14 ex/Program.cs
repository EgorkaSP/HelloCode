//14. Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (Number > 999)
{
    int LastNumber = Number % 100;
    int ThirdDigit = LastNumber / 10;
    Console.WriteLine(ThirdDigit);
}
else
{
   int ThirdDigit = Number%10;
Console.WriteLine(ThirdDigit);
}
