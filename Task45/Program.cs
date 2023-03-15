// Задача 45:
// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.


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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] CopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}

void Main()
{
Console.Write("Введите размерность массива (целое положительное число): ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(sizeArr, 0, 9);
Console.Write(" Исходный массисв: ");
PrintArray(array);
Console.WriteLine();
int[] copyArr = CopyArray(array);
Console.Write(" Массив - копия -> ");
PrintArray(copyArr);
}

Main();