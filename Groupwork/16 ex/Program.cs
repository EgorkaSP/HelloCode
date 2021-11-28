Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine());
if (day >= 1 && day < 6 ) Console.WriteLine("Будний день");
if (day >= 6) Console.WriteLine("Выходной день");
if (day > 7) Console.WriteLine("Не существует");