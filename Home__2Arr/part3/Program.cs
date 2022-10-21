// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.WriteLine("Введите размерность двухмерного массива");
int n = int.Parse(Console.ReadLine() ?? "0");
int m = int.Parse(Console.ReadLine() ?? "0");

void FillArr(int [,] arr){

for (int i = 0; i < n; i++ ){
    for (int j = 0; j < m; j++){
        arr[i,j] = new Random().Next(2,4); 
      
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
 Console.WriteLine();
}

void SquaerArr(int [,] arr){
  for (int i = 0; i < n; i++ ){
    for (int j = 0; j < m; j++){
      
       if (arr[i,j] % 2 == 0 && arr[j,i] %2==0){
            arr[i,j]= arr[i,j]*arr[i,j];
        } 
       
    }
}
}   

int [,] Array = new int [n,m];
FillArr(Array);
PrintArray(Array);

SquaerArr(Array);
PrintArray(Array);