// Задача 51:
// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1,1) и т.д. 

// Например, задан массив:
// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4 
// сумма элементов главной диагонали: 1+9+2=12


// int[,] array2D = new int[3, 4];
// int[,] array2D = new int[3, 4] {
//     { 1, 4, 7, 2 },
//     { 5, 9, 2, 3 },
//     { 8, 4, 2, 4} };

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


// int SumElemDiagMatrix(int[,] matrix)
// {
//     int sumElemDiagMatrix = 0;
//     int sizeRows = matrix.GetLength(0);
//     int sizeColums = matrix.GetLength(1);
//     int j = 0;
//     for (int i = 0; i < sizeRows; i++)
//     {
//         sumElemDiagMatrix = sumElemDiagMatrix + matrix[i, j];
//         j++; 
//     }
//     return sumElemDiagMatrix;
// }

int SumElemDiagMatrix(int[,] matrix)
{
    int sum = 0;
    int sizeRows = matrix.GetLength(0);
    int sizeColums = matrix.GetLength(1);
    int i = 0;
    int j = 0;
    while (i < matrix.GetLength(0) && j <matrix.GetLength(1))
    {
        if (i == j)
        {
            sum += matrix[i, j];
            i++;
            j++;
        }
    }
    return sum;
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}


void Main()
{
    int[,] array2D = CreateMatrixRndInt(4, 6, 0, 10);
    Console.WriteLine("Для 2D-массива): ");
    PrintMatrix(array2D);
    int sum = SumElemDiagMatrix(array2D);
    Console.WriteLine($"сумма элементов главной диагонали: {sum}.");
}

Main();