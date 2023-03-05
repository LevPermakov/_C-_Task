// 11. Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого 
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(99, 1000);
Console.WriteLine($"Случайное число в диапазоне: 100-999: -> {number}");

//************** Вариант 1 *******************************
int firstNumber = number / 100;
int thirdNumber = number % 10;
Console.WriteLine($"{number} -> {firstNumber}{thirdNumber}");

//************** Вариант 2 - Функция *********************
int resultDigit = Together1and3digit(number);
Console.WriteLine($"{number} --> {resultDigit}");

int Together1and3digit(int num)
{
    int firstNumber = number / 100;
    int thirdNumber = number % 10;
    int result = firstNumber * 10 + thirdNumber;
    return result;
}
