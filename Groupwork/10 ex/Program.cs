// 10. Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int  MainNumber = Convert.ToInt32(Console.ReadLine());
if (MainNumber >= 100 && MainNumber <= 999)
{
 int FirstNumber = MainNumber% 100;
 int secondDigit = FirstNumber/10;
 Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Число не трехзначное");
}



