// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
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
int max = array[i];
int min = array[i];
int productOfNumbers = 0;

for (i = 0; i < array.Length; i++){
    if (max < array[i]){
        max = array[i];
    }
    if(min > array[i]){
        min = array[i];
    }
    Console.WriteLine($"max = {max} min = {min}");
}
productOfNumbers = max - min;
Console.WriteLine("разница =" +productOfNumbers);

