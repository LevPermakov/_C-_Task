// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите размерность массива (целое положительное число): ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(sizeArr, 0, 9);

Console.Write("Введите число для сравнения: ");
int numberArr = Convert.ToInt32(Console.ReadLine());
// if (FindNumber (numberArr, array) == true) 
// {
//     Console.Write($" Число {numberArr} в массиве: ");
//     PrintArray(array);
//     Console.Write(" -> да");
// }
// else
// {
//     Console.Write($" Числа {numberArr} в массиве: ");
//     PrintArray(array);
//     Console.Write(" -> нет");
// }
Console.Write($" Число {numberArr} в массиве: ");
PrintArray(array);
Console.Write(" -> ");
Console.Write(FindNumber (numberArr, array) == true ? "да" : "нет");



int[] CreateArrayRndInt(int number, int min, int max)
{
    int[] arr = new int[number];
    Random rnd = new Random();
    for (int i = 0; i < number; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

bool FindNumber(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i]) return true;
    }
    return false;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

