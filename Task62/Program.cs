// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] CreateMatrixSpiralToRight(int rows, int colums, int min)
{
    int[,] matrix = new int[rows, colums];
    int value = min;
    int iMax = colums;
    int jMax = rows;
    int iMin = 0;
    int jMin = 0;
    while (value <= rows * colums)
    {
        int i = iMin;                               //  i const = iMin
        for (int jr = jMin; jr < jMax; jr++)        //  j right   от jMin до jMax
        {
            matrix[i, jr] = value;
            value++;
        }
        iMin++;
        int j = jMax - 1;                           //  j const = jMax-1
        for (int id = iMin; id < iMax; id++)        //  i down 
        {
            matrix[id, j] = value;
            value++;
        }
        jMax--;
        i = iMax - 1;
        for (int jl = jMax - 1; jl >= jMin; jl--)    //  j left
        {
            matrix[i, jl] = value;
            value++;
        }
        iMax--;
        j = jMin;
        for (int iup = iMax - 1; iup >= iMin; iup--)     //  i up 
        {
            matrix[iup, j] = value;
            value++;
        }
        jMin++;
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


void Main()
{
    int[,] matrixA = CreateMatrixSpiralToRight(4, 4, 1);

    Console.WriteLine();
    Console.WriteLine("Матрица А: ");
    PrintMatrix(matrixA);


    // Console.WriteLine();
    // Console.WriteLine("Матрица B: ");
    // PrintMatrix(matrixB);

    // int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
    // Console.WriteLine();
    // Console.WriteLine("Произведение матриц - Матрица C: ");
    // PrintMatrix(matrixC);
}

Main();
