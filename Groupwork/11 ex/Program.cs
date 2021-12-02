// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Write("Введите число от 10 до 99: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber >=10 && FirstNumber <=99)
{
int FirstDigit = FirstNumber/10;
int SecondDigit = FirstNumber%10;
if (FirstDigit > SecondDigit)
{
    Console.WriteLine(FirstDigit);
}
else if (SecondDigit > FirstDigit)
{
    Console.WriteLine(SecondDigit);
}
else
{
    Console.WriteLine("Цифры равны");
}
}
else
{Console.WriteLine("Число не находится в заданном отрезке");
}