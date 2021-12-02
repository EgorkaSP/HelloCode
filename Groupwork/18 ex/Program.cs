// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Write("Введите первое значение: ");
bool x = Convert.ToBoolean(Console.ReadLine());
Console.Write("Введите второе значение: ");
bool y = Convert.ToBoolean(Console.ReadLine());
bool F1 = !(x || y);
bool F2 = !x && !y;
if (F1 == F2)
{
    Console.WriteLine("Утверждение истинно!");
}
else
{
    Console.WriteLine("Утверждение ложно!");
}






// if (x == false && y == false)
// {
// bool F = x && y;
// Console.WriteLine(F);
// }
// else if (x == false && y == true)
// {
// bool F = x && y;
// Console.WriteLine(F);
// }
// else if (x == true && y == false)
// {
// bool F = x && y;
// Console.WriteLine(F);
// }
// if (x == true && y == true)
// {
//  bool F = x && y;
// Console.WriteLine(F);
// }