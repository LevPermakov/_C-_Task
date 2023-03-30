// Задача 63:
// Задайте значение N.
// Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if(num == 0) return;
    // Console.Write($"{num} "); // 
    NaturalNumbers (num -1);     // Хвостовой метод (когда рекурия завершает метод). Вывод: 5 4 3 2 1
    Console.Write($"{num} ");    // Вывод: 1 2 3 4 5

}