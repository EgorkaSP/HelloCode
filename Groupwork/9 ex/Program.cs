//  9. Показать последнюю цифру трёхзначного числа

Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int lastdigit = number % 10;
    Console.WriteLine(lastdigit);
}


else
{Console.WriteLine("Число не трехзначное");
}


