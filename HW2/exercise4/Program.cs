// Программа проверяет пятизначное число на палиндромом
/* Console.WriteLine("Введите пятизначное число");
int  N = int.Parse(Console.ReadLine() ?? "0");
string str = N.ToString();
char [] arr;
char [] arr2;
arr = str.ToCharArray();
arr2 = str.ToCharArray();

int i = 0;
while (i < arr.Length){ 
    Console.Write(arr[4-i]);
    i++;
}
i=0;
while (i < arr2.Length){ 
    Console.Write(arr2[0+i]);
    i++;
}

if (arr == arr2){
    Console.WriteLine("Является полиндромом");
} else {
    Console.WriteLine("Не является полиндромом");
} */

/* int L = str.Length;
int i = 0;
string N2 ;
while (i<str.Length){
    Console.WriteLine(str.Length-1 + N2 );
    i++;

}
Console.WriteLine(str+i);




/* class Program
{
    public static bool IsPalindromicNumber (int number)
    {
        if (number < 0)
        {
            throw new ArgumentException($"{number} is less than zero!");
        }

        int numberTemp = number;

        int value;

        int numberRevers = 0;

        while (numberTemp > 0)
        {
            value = numberTemp % 10;
            numberRevers = numberRevers * 10 + value;
            numberTemp /= 10;
        }

        if (numberRevers == number)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPalindromicNumber(a));
    }
} */