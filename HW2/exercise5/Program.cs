// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите координаты 1 точки x,y");
double xa = double.Parse(Console.ReadLine() ?? "0");
double ya = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координаты 2 точки x,y");
double xb = double.Parse(Console.ReadLine() ?? "0");
double yb = double.Parse(Console.ReadLine() ?? "0");

double xc = xb-xa;
double yc = yb-ya;
double xy = Math.Sqrt((xc*xc) + (yc*yc));

Console.WriteLine("Расстояние между двуймя точками на плоскости = " + xy);

