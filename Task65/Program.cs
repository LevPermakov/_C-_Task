// Задача 65:
// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> '4, 5, 6, 7, 8'



Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if(num == 0) return;
    // Console.Write($"{num} "); // 
    NaturalNumbers (num -1);     // Хвостовой метод (когда рекурия завершат метод). Вывод: 5 4 3 2 1
    Console.Write($"{num} ");    // Вывод: 1 2 3 4 5

}

Console.Write("Введите первое целое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое положительное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
// проверка num1
NaturalNumbersMtoN(num1, num2);
// проверка num2

void NaturalNumbersMtoN(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbersMtoN(num1 - 1, num2);
    }
    else if (num1 < num2)
    {
        NaturalNumbersMtoN(num1, num2 - 1);
        Console.Write($"{num2} ");
    }

    else //  (num1 == num2)
    {
        Console.Write($"{num1} ");
    }
}