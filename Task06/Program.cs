// Задача 6: 
// Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
//
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Convert.ToInt32(number % 2);
// Console.WriteLine(result);
if (result == 0) 
{ 
    Console.WriteLine($"Число {number} является четным.");
}
else 
{
    Console.WriteLine($"Число {number} не является четным.");
} 