// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введите точку по оси X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0) Console.WriteLine("Точка находится в первой четверти");
if (x < 0 && y > 0) Console.WriteLine("Точка находится во второй четверти");
if (x < 0 && y < 0) Console.WriteLine("Точка находится в третьей четверти");
if (x > 0 && y < 0) Console.WriteLine("Точка находится в четвертой четверти");