// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
switch (FirstNumber % SecondNumber)
{
    case 0:
        Console.WriteLine("Число " + FirstNumber + " кратно " + SecondNumber);
        break;
    default:
        Console.WriteLine("Число " + FirstNumber + " некратно " + SecondNumber);
        break;
}