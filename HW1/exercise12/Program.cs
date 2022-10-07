// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine() ?? "0");
int B = N;
int i = 0;
int count = 0;
bool f = true;


while (f) {
N = N/10;
count++;
if (N<1) {
    f = false;
}
} // нашел длину, count
if (B<100) {
    Console.WriteLine("нет третьего числа");
}else{
        B = B*1000;
        while (i<count){
        B = B/10;
        i++;
        }
        B = B % 10;
        Console.WriteLine("третье число = " +B);
}
