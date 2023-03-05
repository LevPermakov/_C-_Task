// 9. Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

//******************** Вариант 1 ***************************************
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 --> {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");
}

//********************** Вариант 2 *************************************
// Условный (Тернарный) оператор
int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа --> {result}");

int maxDigit= MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");

//*********************** Вариант 3 ************************************
// Метод (функция)-возвращает значение 
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}

//**********************************************************************