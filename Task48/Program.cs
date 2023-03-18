// Задача 48:
// Задайте двумерный массив размера m на n,
// Каждый элемент массива находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.

// m=3, n=4.
// 0123
// 1234
// 2345


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
    int rows = 3;
    int colums = 4;
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    PrintMatrix(matrix);
}

Main();