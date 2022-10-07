// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число которое является корнем второго числа");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
int B = int.Parse(Console.ReadLine() ?? "0");
 
    if (B % A == 0) {
       Console.WriteLine( B + " Является квадратом "+A ); 
    }else{
       Console.WriteLine(B +" Не является квадратом "+ A);  
    }

    if (A % B == 0) {
       Console.WriteLine( A + " Является квадратом "+B ); 
    }else {
        Console.Writeline(A+ " Не является квадратом " +B);
    }
    