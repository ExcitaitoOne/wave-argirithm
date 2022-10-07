// Программа проверяет пятизначное число на палиндромом


Console.WriteLine("Введите пятизначное число");
int B = int.Parse(Console.ReadLine() ?? "0");

int a1 = B / 10000; 
int a2 = B % 10;

int b1 = B / 1000;
b1 = b1 % 10; 
int b2 = B % 100;
b2=b2/10;
if ((a1==a2)&& (b1==b2)){
    Console.WriteLine("Число является палиндромом");
}else{
    Console.WriteLine("Число не является палиндромом"); 
}