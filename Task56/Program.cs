// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка




// int[,] array2d = new int[,]
// {
// {1, 4, 7, 2},
// {5, 9, 2, 3}, 
// {8, 4, 2, 4} 
// };

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
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}

void PrintArray1d(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.WriteLine();
}

int[] SumElementRowMatrix(int[,] array2d)
{
    int numberRows = array2d.GetLength(0);
    int numberColums = array2d.GetLength(1);
    int[] arr = new int[numberRows];
    int result = 0;
    for (int i = 0; i < numberRows; i++)
    {
        int sumRow = 0;
        for (int j = 0; j < numberColums; j++)
        {
            sumRow = sumRow + array2d[i, j];
        }
        arr[i] = sumRow;
    }
    return arr;
}

int MinSumArray1d (int[] arr1d)
{
    int lengthArr = arr1d.Length;
    int value = int.MaxValue;
    int number = 0;
    for (int i = 0; i < lengthArr; i++)
    {
        if (arr1d[i] < value)
        {
            value = arr1d[i];
            number = i + 1;
        }
    }
    return number;
}


void Main()
{
    int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
    Console.WriteLine();
    Console.WriteLine("Для массива: ");
    PrintMatrix(array2d);
    int[] arrSumRow = SumElementRowMatrix(array2d);
    // Console.Write("Сумма для каждой строки матрицы: ");
    // PrintArray1d(arrSumRow);
    // Console.WriteLine();
    int minSumArray1d = MinSumArray1d (arrSumRow);
    Console.Write($"{minSumArray1d} строка");

}

Main();
