// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Произведением матрицы Amxn на матрицу Bnxk 
// называется матрица Cmxk такая, что элемент матрицы C, стоящий в i-ой строке и j-ом столбце, 
// т.е. элемент Cij, равен сумме произведений элементов i-ой строки матрицы A 
// на соответствующие элементы j-ого столбца матрицы B.




int[,] matrixA = new int[,]
{
{2, 4},
{3, 2},
};

int[,] matrixB = new int[,]
{
{3, 4},
{3, 3},
};


int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixB.GetLength(1), matrixA.GetLength(0)];
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Ошибка! Количество столбцов матрицы A не равно количеству строк матрицы B.");
        // return matrixC;
    }
    else
    {
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (var j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

    }
    return matrixC;
}

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



void Main()
{
    int[,] matrixA = CreateMatrixRndInt(5, 2, 0, 9);
    int[,] matrixB = CreateMatrixRndInt(2, 5, 0, 9);
    // Количество столбцов матрицы A д.б. равно количеству строк матрицы B.");
    Console.WriteLine();
    Console.WriteLine("Матрица А: ");
    PrintMatrix(matrixA);
    Console.WriteLine();
    Console.WriteLine("Матрица B: ");
    PrintMatrix(matrixB);
    int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
    Console.WriteLine();
    Console.WriteLine("Произведение матриц - Матрица C: ");
    PrintMatrix(matrixC);
}

Main();
