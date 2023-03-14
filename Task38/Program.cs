// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double MaxElementArray(double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)  max = arr[i];
    } 
    return max;
}

double MinElementArray(double[] arr)
{
    // public const int MaxValue = 2147483647;
    double min = Int32.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)  min = arr[i];
    } 
    return min;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


void Main()
{
Console.Write("Введите размерность массива (целое положительное число): ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndDouble(sizeArr, 0, 99);
double maxElementArray = MaxElementArray(array);
double minElementArray = MinElementArray(array);
double result = maxElementArray - minElementArray;
result = Math.Round(result, 1, MidpointRounding.ToZero);
Console.Write(" В массиве: ");
PrintArray(array);
Console.Write($" разница между максимальным и минимальным элементом -> {result}");
}

Main();
