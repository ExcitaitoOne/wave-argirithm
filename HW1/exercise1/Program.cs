// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите первое число которое является корнем второго числа");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
int B = int.Parse(Console.ReadLine() ?? "0");
 
    if (A % B == 0) {
       Console.Write("Является квадратом"); 
    }else {
        Console.Write("Не является квадратом");
    }
    


