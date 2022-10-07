// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти (1,2,3,4)");
int N = int.Parse(Console.ReadLine() ?? "0");
int x,y;

switch (N) {
    case 1: Console.WriteLine("при X > 0, Y > 0");
    break;
    case 2: Console.WriteLine("при X < 0, Y > 0");
    break;
     case 3: Console.WriteLine("при X < 0, Y < 0");
    break;
     case 4: Console.WriteLine("при X > 0, Y < 0");
    break;
}