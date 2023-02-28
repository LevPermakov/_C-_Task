// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, 
// 1. которая на вход принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число: ");
// string str = Console.ReadLine();
// int number = Convert.ToInt32(str);
// ??? warning CS8600: Преобразование литерала, допускающего значение NULL или возможно 
// ??? го значения NULL в тип, не допускающий значение NULL.
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} равен {square}");