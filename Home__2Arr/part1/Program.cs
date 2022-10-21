//Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine("Введите размерность двухмерного массива");
int n = int.Parse(Console.ReadLine() ?? "0");
int m = int.Parse(Console.ReadLine() ?? "0");

void FillArr(int [,] arr){

for (int i = 0; i < n; i++ ){
   
    for (int j = 0; j < m; j++){

        arr[i,j] = new Random().Next(1,10); 
         
    }

}
}
void PrintArray(int[,] arr){
for (int i = 0; i < n; i++ ){
    for (int j = 0; j < m; j++){
       Console.Write(" "+arr[i,j]);
   }
   Console.WriteLine();
}
}


int [,] Array = new int [n,m];
FillArr(Array);
PrintArray(Array);