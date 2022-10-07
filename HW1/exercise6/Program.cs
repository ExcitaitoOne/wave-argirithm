// Показать четные числа от 1 до N
Console.WriteLine("Введите отрицательное число");
int N = int.Parse(Console.ReadLine() ?? "0");
int A = 1;
while (A < N) {    
    if (A % 2 == 0) {
        A=A+1; 
    } else{
        A=A+1;
        Console.Write(A +", ");
    }
}

