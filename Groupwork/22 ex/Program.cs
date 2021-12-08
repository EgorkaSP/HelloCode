// 22. Найти расстояние между точками в пространстве 2D/3D

// double Dist(double x1, double x2, double y1, double y2)
// {
//     double AB = y2 - y1;
//     double BC = x2 - x1;
//     double AC = Math.Sqrt(AB + BC);
//     return AC;
// }
// double distance = Dist(3.0, 6.0, 3.0, 9.0);
// Console.WriteLine(distance);
// Для 3D пространства


int xa = Convert.ToInt32(Console.ReadLine());
int xb = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());
int dist3d = Convert.ToInt32(Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za)));
System.Console.WriteLine(dist3d);