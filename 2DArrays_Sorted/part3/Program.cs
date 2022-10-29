//В прямоугольной матрице найти строку с наименьшей суммой элементов.

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


int LineSum(int[,] arr, int arg)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        sum = sum + arr[arg,i]; 
  return sum;
}

int Sum(int [,] arr, int [] line){
    int sum = 0;
 for (int i = 0; i < arr.GetLength(0); i++){
    line[i] = LineSum(arr,i);
    
 }
  return sum;
}

int[,] array = new int[n, m];
int[] Massiv =new int [m]; 

FillArr(array);
PrintArray(array);
Sum(array,Massiv);

for (int i = 0; i < Massiv.Length; i++){
    Console.Write(" " + Massiv[i]);
}
Console.WriteLine();

int min = Massiv[0];
for (int i = 0; i < Massiv.Length; i++){
  if (Massiv[i] <= min){
    min = Massiv[i];
  }  
}
Console.WriteLine(" Минимальная сумма линий массива " + min);



