// Написать программу масштабирования фигуры

Console.WriteLine("Задайте вершины фигуры");
 
Console.WriteLine("Вершина 1");
int k1 = int.Parse(Console.ReadLine()  ?? "0");
int a1 = int.Parse(Console.ReadLine()  ?? "0");
Console.WriteLine("Вершина 2");
int k2 = int.Parse(Console.ReadLine()  ?? "0");
int a2 = int.Parse(Console.ReadLine()  ?? "0");
Console.WriteLine("Вершина 3");
int k3 = int.Parse(Console.ReadLine()  ?? "0");
int a3 = int.Parse(Console.ReadLine()  ?? "0");
Console.WriteLine("Вершина 4");
int k4 = int.Parse(Console.ReadLine()  ?? "0");
int a4 = int.Parse(Console.ReadLine()  ?? "0");

string str = "раз";


Console.Write($"заданы вершины фигуры: ({k1},{a1}),({k2},{a2}),({k3},{a3}),({k4},{a4}) ");
Console.WriteLine();
int [] arr = new int [8] {k1,a1,k2,a2,k3,a3,k4,a4};
Console.WriteLine("Введите множетель K");
int k = int.Parse(Console.ReadLine() ?? "0");
if (k == 2 || k==3 || k == 4) str = "раза";
for (int i = 0; i < arr.Length; i++) arr[i] = arr[i] * k;
Console.Write($"масштабирование в {k} {str} : ({arr[0]},{arr[1]}),({arr[2]},{arr[3]}),({arr[4]},{arr[5]}),({arr[6]},{arr[7]}) ");