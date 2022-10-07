// Выяснить является ли число чётным

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine() ?? "0");

 
    if (A % 2 == 0) {
       Console.Write("Является четным"); 
    }else {
        Console.Write("Не является четным");
    }
    
