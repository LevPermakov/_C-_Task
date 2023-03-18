// Задача 49:
// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса четные, 
// и замените эти элементы на их квадраты.

// Например, исходный массив:
// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4

// Новый массив:
//   1  4  49  2
//   5  9   2  3 
//  64  4   4  4


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

// int[,] CreatNewMatrix(int[,] matrix)
// {
//     int sumElemDiagMatrix = 0;
//     int sizeRows = matrix.GetLength(0);
//     int sizeColums = matrix.GetLength(1);
//       for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColums; j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) matrix [i,j] = matrix [i,j] * matrix [i,j];
//         }
//     }
//     return matrix;
// }

void ReplaceNumberToSquare(int[,] matrix)
{
    int sumElemDiagMatrix = 0;
    int sizeRows = matrix.GetLength(0);
    int sizeColums = matrix.GetLength(1);
      for (int i = 0; i < sizeRows; i=i+2)
    {
        for (int j = 0; j < sizeColums; j=j+2)
        {
            if (i % 2 == 0 && j % 2 == 0) 
            // matrix [i,j] = matrix [i,j] * matrix [i,j];
            matrix [i,j] *= matrix [i,j];
        }
    }
}


void Main()
{
    int[,] array2D = CreateMatrixRndInt(5, 4, 0, 10);
    Console.WriteLine("Исходный 2D-массив: ");
    PrintMatrix(array2D);
    // int[,] array2Da = CreatNewMatrix(array2D);
    ReplaceNumberToSquare(array2D);
    Console.WriteLine("Новый 2D-массив: ");
    // PrintMatrix(array2Da);
    PrintMatrix(array2D);
}

Main();