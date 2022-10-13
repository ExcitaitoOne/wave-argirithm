// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void EnterArray(int[] array)
{
    Console.WriteLine("Вывод массива ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($" {array[i]},");
    }
}

int[] array = new int[10];

EnterArray(array);
Console.WriteLine();
int i = 0;
int sum = 0;

for (i = 0; i < array.Length; i++)
{

    if (array[i] % 2 == 1)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine($" сумма = {sum}");


