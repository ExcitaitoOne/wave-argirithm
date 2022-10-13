// Подсчитать сумму цифр в числе
Console.WriteLine("Enter number N ");
int N = int.Parse(Console.ReadLine());
int LongNum = 1;
int M = N;

if (M < 0)
{
    M = M * -1;
}
for (int i = 0; i < M; i++)
{
    if (M > 10)
    {
        M = M / 10;
        LongNum++;
    }
}
Console.WriteLine("Длина числа " + LongNum);

int sum = 0;

for (int j = 0; j < LongNum; j++)
{
    int Ost = N;
    if (N != 0)
    {
        Ost = N % 10;
        Console.WriteLine("Остаток " + Ost);
        N = N / 10;
        sum = sum + Ost;
    }
    else
    {
        Console.WriteLine("End");
    }
}

if (M < 0)
{
    sum = sum * -1;
}
Console.WriteLine("сумма = " + sum);