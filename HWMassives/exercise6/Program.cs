// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void EnterArray(int[] array)
{
    Console.WriteLine("Вывод массива ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($" {array[i]},");
    }
}

int[] array = new int[11];

EnterArray(array);
Console.WriteLine();
int i = 0;
int sum = 0;
int mass1 = 1;
int mass2 = 1;
 

for (i = 0; i < array.Length / 2; i++)
{
    mass1 = array[i];
    mass2 = array[array.Length-1 - i];
    sum = mass1 * mass2;
    Console.WriteLine($" {mass1} * {mass2} = {sum}");
   }

