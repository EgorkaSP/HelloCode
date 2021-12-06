// 20. Задать номер четверти, показать диапазоны для возможных координат

int quarterNumber = new Random().Next(1, 4);
Console.WriteLine("Номер четверти: "+ quarterNumber);
if (quarterNumber == 1) Console.WriteLine("x от 0 до плюс бесконечности, y от 0 до плюс бесконечности");
if (quarterNumber == 2) Console.WriteLine("x от 0 до минус бесконечности, y от 0 до плюс бесконечности");
if (quarterNumber == 3) Console.WriteLine("x от 0 до минус бесконечности, y от 0 до минус бесконечности");
if (quarterNumber == 4) Console.WriteLine("x от 0 до плюс бесконечности, y от 0 до минус бесконечности");