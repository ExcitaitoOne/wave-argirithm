// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Enter a number ");
int N = int.Parse(Console.ReadLine());
int sum = N;

for (int i = 1; i <= N; i++)
{
    sum = i * i * i;
    if (sum % 2 == 0)
    {
        Console.WriteLine($"Number = {i} cube number = {sum}");
    }
}
