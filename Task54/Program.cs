// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array2d = new int[,]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4}
};


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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

int[] TakeRowArray2d(int[,] array2d, int iRow)
{
    int numColm = array2d.GetLength(1);
    int[] array1d = new int[numColm];
    int k = 0;
    for (int j = 0; j < numColm; j++)
    {
        array1d[k] = array2d[iRow, j];
        k++;
    }
    return array1d;
}


void ReplaceReverseRowArray2d(int[,] array2d, int iInd, int[] row)
{
    int numColm = array2d.GetLength(1);
    for (int j = 0; j < numColm; j++)
    {
        array2d[iInd, j] = row[numColm - j - 1]; 
    }
}


void Main()
{
    // int[,] array2d = CreateMatrixRndInt(5, 5, -0, 9);
    Console.WriteLine("  Исхоный массив: ");
    PrintMatrix(array2d);
    for (int i = 0; i < array2d.GetLength(1) - 1; i++)
    {
        int[] rowArray2d = TakeRowArray2d(array2d, i);
        Array.Sort(rowArray2d);
        ReplaceReverseRowArray2d(array2d, i, rowArray2d);
    }
    Console.WriteLine("  выполнена сортировка: ");
    PrintMatrix(array2d);
}

Main();
