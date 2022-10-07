// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите день недели");
int A = int.Parse(Console.ReadLine() ?? "0");
bool B = false;
switch (A)
{
    case 1:  Console.WriteLine("Понедельник");
    break; 
     case 2:  Console.WriteLine("Вторник");
    break; 
     case 3:  Console.WriteLine("Среда");
    break; 
     case 4:  Console.WriteLine("Четверг");
    break; 
     case 5:  Console.WriteLine("Пятница");
    break; 
     case 6:  Console.WriteLine("Суббота");
      B = true;
    break; 
     case 7:  Console.WriteLine("Воскресенье");
      B = true;
    break; 
    default: Console.WriteLine("Не является днем недели");
    break; 
} 
if (B == true) {
     Console.WriteLine("Выходной");
} else {
     Console.WriteLine("Рабочий день");
}
