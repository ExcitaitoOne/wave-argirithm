// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите первое число");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
int B = int.Parse(Console.ReadLine() ?? "0");

if (A % B == 0) {
    Console.WriteLine("Число кратно");
} else {
    A = A % B;
    Console.WriteLine("Остаток " +A);
}