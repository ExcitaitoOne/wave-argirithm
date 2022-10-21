// Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.WriteLine("Введите размерность двухмерного массива");
int n = int.Parse(Console.ReadLine() ?? "0");
int m = int.Parse(Console.ReadLine() ?? "0");

void FillArr(int [,] arr){

for (int i = 0; i < n; i++ ){
   
    for (int j = 0; j < m; j++){
        
       arr[i,j] = arr[i,j] + (i+j);
     
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