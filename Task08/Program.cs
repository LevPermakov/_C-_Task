// Задача 8: 
// Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое положительное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"Четные числа в диапазоне от 1 до {numberN}: ");
for (int index = 2; index <= numberN; index = index + 2)
{
    if (index < numberN-1)
    {
        Console.Write($" {index}, ");
    }
    else
    {
        Console.Write($" {index}");
    }
}
