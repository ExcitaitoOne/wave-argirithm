// Найти кубы чисел от 1 до N
Console.WriteLine("Enter a number ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++){
    int sum = i * i * i;
    Console.WriteLine($"Number = {i} cube number = {sum}");
}