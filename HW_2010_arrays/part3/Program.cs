// Написать программу копирования массива

void EnterMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
}
void PrintMass(int[] arr){
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
      Console.WriteLine();
}

void CopyMass(int[] arr, int [] arrCopy)
{
   
    for (int i = 0; i < arr.Length; i++){
       arrCopy[i] = arr[i]; 
   }
     
}

int[] array = new int[10];
int[] CopyArray = new int [10];
EnterMass(array);
PrintMass(array);

CopyMass(array, CopyArray);
PrintMass(CopyArray);
