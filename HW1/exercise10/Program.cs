// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int A = int.Parse(Console.ReadLine() ?? "0");
int one;
int three;
one = A /100;
three = A%10;

Console.WriteLine("Число без второй цифры " + one+ three);