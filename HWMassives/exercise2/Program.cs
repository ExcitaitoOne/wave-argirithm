// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

void EnterArray(int [] array){
Console.WriteLine("Вывод массива ");
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(0,9);
    Console.Write($" {array[i]},");
}
}

int [] array = new int[12];

EnterArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i++){
    sum = sum + array[i];
}
Console.WriteLine();
Console.WriteLine($" сумма = {sum}");

