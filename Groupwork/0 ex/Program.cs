//  0. Вывести квадрат числа

// Console.WriteLine("Введите число: ");
// double x = double.Parse(Console.ReadLine());
// double stepen = 2.0;
// double result = Math.Pow(x,stepen);
// Console.WriteLine(result);
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number*number;
Console.Write("Результат: " + result);
