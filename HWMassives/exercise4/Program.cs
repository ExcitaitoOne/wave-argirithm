// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void EnterArray(int[] array)
{
    Console.WriteLine("Вывод массива ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 99);
        Console.Write($" {array[i]},");
    }
}

int[] array = new int[123];

EnterArray(array);

Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if ((i > 10) && (i < 99))
    {
        count++;
    }

}
Console.Write("Количество элементов в отрезке : " + count);



