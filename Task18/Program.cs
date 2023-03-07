// Task18
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек  
// в этой четверти (x и Y).


Console.Write("Введите квадрант: ");
int quadrantrd = Convert.ToInt32(Console.ReadLine());

string range = Range(quadrantrd);

Console.WriteLine(range);

string Range(int quadr)
{
    // public const int MaxValue = 2147483647;
    if (quadr == 1) return  $" 0 < x < {Int32.MaxValue}, 0 < y < {Int32.MaxValue}";
    if (quadr == 2) return  $" -{Int32.MaxValue} < x < 0, 0 < y < {Int32.MaxValue}";
    if (quadr == 3) return  $" -{Int32.MaxValue} < x < 0, -{Int32.MaxValue} < y < 0";
    if (quadr == 4) return  $" 0 < x < {Int32.MaxValue}, -{Int32.MaxValue} < y < 0";
    return "Значение квадранта некорректно.";
}