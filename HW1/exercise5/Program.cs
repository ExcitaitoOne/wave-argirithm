// Показать числа от -N до N
Console.WriteLine("Введите отрицательное число");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите положительное число");
int B = int.Parse(Console.ReadLine() ?? "0");
A = A - 1;
if ((A < 0) && (B > 0)){
    while (A!= B){
        
        A = A+1;
        Console.Write(A + ", " );
    }
} 
else
Console.WriteLine("Ввели некоректные значения"); 
