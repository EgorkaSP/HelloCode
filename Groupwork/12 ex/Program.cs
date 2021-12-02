// 12. Удалить вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number >= 100 && Number <= 999)
{
    int LastDigit = Number % 10;
    int FirstDigit = Number / 100;
    Console.Write(FirstDigit);
    Console.WriteLine(LastDigit);
}
else{
    Console.WriteLine("Число не трехзначное");
}
