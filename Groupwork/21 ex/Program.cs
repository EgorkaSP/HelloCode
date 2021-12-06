// 21. Программа проверяет пятизначное число на палиндром.

Console.WriteLine("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int FirstDigit = x / 10000;
int SecondNumber = x / 1000;
int SecondDigit = SecondNumber % 10;
int ThirdNumber = x / 100;
int ThirdDigit = ThirdNumber % 10;
int FourthNumber = x % 100;
int FourthDigit = FourthNumber / 10;
int FifthDigit = x % 10;
if (FirstDigit / FifthDigit == 1 && SecondDigit / FourthDigit == 1)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не палиндром");
}








// Console.WriteLine("Введите пятизначное число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int FirstDigit = x / 10000;
// int SecondNumber = x / 1000; int SecondDigit = SecondNumber % 10;
// int ThirdNumber = x / 100; int ThirdDigit = ThirdNumber % 10;
// int FourthNumber = x % 100; int FourthDigit = FourthNumber / 10;
// int FifthDigit = x % 10;
// Console.WriteLine($"{FirstDigit}, {SecondDigit}, {ThirdDigit}, {FourthDigit}, {FifthDigit} ");
