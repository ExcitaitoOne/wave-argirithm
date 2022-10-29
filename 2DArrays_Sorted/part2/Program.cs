//Написать программу, которая в двумерном массиве заменяет строки на столбцы 
//или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.WriteLine(" введите размерность двумерногоо массива");
int n = int.Parse(Console.ReadLine() ?? "0");
int m = int.Parse(Console.ReadLine() ?? "0");

void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(" " + arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void Zamena(int[,] arr)
{
    
    int length = arr.GetLength(0);
    int temp;
    for (int i = 0; i < length; i++)
        for (int j = i + 1; j < length; j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
  
}

int[,] array = new int[n, m];

if (n == m) {
FillArr(array);
PrintArray(array);
Zamena(array);
PrintArray(array);
} else {
    Console.WriteLine("Невозможно преобразовать массив");
}