// 3. По заданному номеру дня недели вывести его название
string[] DaysOfWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int DayOfWeek = Convert.ToInt32(Console.ReadLine());
if ((DayOfWeek -1) >= 0 && (DayOfWeek -1) < DaysOfWeek.Length)
{
Console.WriteLine(DaysOfWeek[DayOfWeek - 1]);
}
else
{
    Console.WriteLine("Мы не знаем такого значения");
}


// Console.Write("Введите номер дня недели: ");
// int dayOfWeek = int.Parse(Console.ReadLine());
// if (dayOfWeek == 1) Console.WriteLine("Понедельник");
// else if (dayOfWeek == 2) 
// {
//     Console.WriteLine("Вторник");
// }

// else if (dayOfWeek == 3) 
// {
//     Console.WriteLine("Среда");

// }
// else if (dayOfWeek == 4)
//  {
//     Console.WriteLine("Четверг");
// }
// else if (dayOfWeek == 5) 
// {
//     Console.WriteLine("Пятница");
// }
// else if (dayOfWeek == 6) 
// {
//     Console.WriteLine("Суббота");
// }
// else if (dayOfWeek == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else {
//     Console.WriteLine("Нет такого дня в неделе");
// }
