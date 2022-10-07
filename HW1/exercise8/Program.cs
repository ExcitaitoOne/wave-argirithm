// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int A = int.Parse(Console.ReadLine() ?? "0");

A = A % 100;
A = A / 10 ;
Console.WriteLine("Вторая цифра " + A);
