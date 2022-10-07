// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int A = int.Parse(Console.ReadLine() ?? "0");

A = A % 10;
Console.WriteLine("Последняя цифра " + A);