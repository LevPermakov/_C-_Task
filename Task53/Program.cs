// Задача 53:
// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.


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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

void ReplaceOneAndLastStrInMatrix(int[,] array2d)
{
    int numLastRow = array2d.GetLength(0) - 1;
    int numLastColum = array2d.GetLength(1) - 1;
    int temp = 0;
    for (int j = 0; j <= numLastColum; j++)
    {
        temp = array2d[0,j];
        array2d[0,j] = array2d[numLastRow,j];
        array2d[numLastRow,j] = temp;
    }
}

void Main()
{
    int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
    Console.WriteLine();
    Console.WriteLine("Для массива: ");
    PrintMatrix(array2d);
    ReplaceOneAndLastStrInMatrix(array2d);
    Console.Write("Поменяли первую и последнюю строку массива: ");
    Console.WriteLine();
    PrintMatrix(array2d);
    Console.WriteLine();
}

Main();
