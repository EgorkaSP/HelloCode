Console.WriteLine("введите трехзначное число");
int number = int.Parse(Console.ReadLine());
int lastdigit = number % 10;
Console.WriteLine(lastdigit);
