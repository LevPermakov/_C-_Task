// Задача 50:
// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Пример:
// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4 
// значение позиции 2D массива (1,7) -> такого элемента в массиве нет.


int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}


void Main()
{
    int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
    Console.WriteLine();
    Console.WriteLine("Для массива: ");
    PrintMatrix(array2d);
    Console.Write("Введите номер строки в массиве (целое положительное число): ");
    int numberRow = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца в массиве (целое положительное число): ");
    int numberColum = Convert.ToInt32(Console.ReadLine());
    if (numberRow >= 0
        && numberRow < array2d.GetLength(0) 
        && numberColum >= 0
        && numberColum < array2d.GetLength(1) )
    Console.WriteLine($"  Значение позиции ({numberRow}, {numberColum}) массива -> {array2d[numberRow, numberColum]} ");
    else
    {
        Console.WriteLine($"  Значение позиции ({numberRow}, {numberColum}) массива -> такого элемента в массиве нет.");
    }
    Console.WriteLine();
}

Main();
