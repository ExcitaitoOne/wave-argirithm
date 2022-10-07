// Найти максимальное из трех чисел



Console.WriteLine("Введиет первое число");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
int B = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Третье число");
int C = int.Parse(Console.ReadLine() ?? "0");
int max = A;
if (A > max){
    max = A;
} else if (B > max) {
  max = B;
} else if (C > max) {
    max = C;
}
Console.WriteLine("максимальлное " + max);