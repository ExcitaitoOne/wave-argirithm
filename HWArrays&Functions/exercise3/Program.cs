// Написать программу вычисления произведения(умножение) чисел от 1 до N
Console.WriteLine("Enter a number ");
int N = int.Parse(Console.ReadLine());
int sum = 1;
for (int i = 1; i <= N; i++)
{
    sum = sum * i;
    Console.WriteLine($"Этап {i} = " + sum);
}
Console.WriteLine("Произведение чисел = " + sum);