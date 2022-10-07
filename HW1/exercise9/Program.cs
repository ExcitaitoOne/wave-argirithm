// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Random rnd = new Random();
int A = rnd.Next(10,99);
int one = A;
int two = A;

one = A / 10;
two = A % 10;
 Console.WriteLine("числло = " + A); 
if (one == two){
    Console.WriteLine (one+" = " +two);
} else
if (one > two){
Console.WriteLine("максимальное первое "+  one);
} else {
   Console.WriteLine("максимальное второе "+ two); 
}
