// Задача 52:
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Пример:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void PrintDoubleArray1d(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.WriteLine();
}

double[] SumElementColumMatrix(int[,] array2d)
{
    int numberRows = array2d.GetLength(0);
    int numberColums = array2d.GetLength(1);
    double[] arr = new double[numberColums];
    double result = 0;
    for (int j = 0; j < numberColums; j++)
    {
        double sumColum = 0;
        for (int i = 0; i < numberRows; i++)
        {
            sumColum = sumColum + array2d[i, j];
        }
        result = sumColum / numberRows;
        result = Math.Round(result, 1, MidpointRounding.ToZero);
        arr[j] = result;
    }
    return arr;
}

void Main()
{
    int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
    Console.WriteLine();
    Console.WriteLine("Для массива: ");
    PrintMatrix(array2d);
    double[] arr = SumElementColumMatrix(array2d);
    Console.Write("Среднее арифметическое для каждого столбца: ");
    PrintDoubleArray1d(arr);
    Console.WriteLine();
}

Main();
