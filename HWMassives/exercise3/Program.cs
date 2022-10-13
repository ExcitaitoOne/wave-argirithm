// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void EnterArray(int [] array){
Console.WriteLine("Вывод массива ");
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(100,999);
    Console.Write($" {array[i]},");
}
}

int [] array = new int[50];

EnterArray(array);

int even = 0;
int notEven = 0;
for(int i = 0; i < array.Length; i++){
    if (array[i] % 2 == 0) {
        even++;
    }else{
        notEven++;
    }

}
Console.WriteLine();
Console.WriteLine($" четные :{even}; нечетные: {notEven};");



