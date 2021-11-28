Console.WriteLine("Введите трехзначное число: ");
int  MainNumber = int.Parse(Console.ReadLine());
int FirstNumber = MainNumber% 100;
int secondDigit = FirstNumber/10;
Console.WriteLine(secondDigit);
