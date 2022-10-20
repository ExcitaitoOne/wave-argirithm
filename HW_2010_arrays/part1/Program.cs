// Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine("Введите K1");
int k1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите K2");
int k2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите B1");
int b1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите B2");
int b2 = int.Parse(Console.ReadLine() ?? "0");

double y = 1;
double x = 1;
double b = 1;
double k = 1;

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine(" Прямые совподают ");
}
else
{
    b = b1 - b2;
    k = k1 - k2;
    if (k1 == k2)
    {
        Console.WriteLine("  ");
    }
    else
    {
        if (b == 0)
        {
            Console.WriteLine("Не имеет решений так как B = 0 (при условии что b не делится на k)");
        }
        else
        {

            x = b / k;
            y = k2 * x + b2;
            Console.WriteLine(" имеет точку пересечения " + x + " , " + y);
        }
    }
}



