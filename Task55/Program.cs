// Задача 55: 
// Задайте двумерный массив.
// Напишите программу, которая заменит строки на столбцы.
// В случае, если это невозможно, программа должна вывести 
// сообщение для пользователя.



// int[,] array2d = new int[,]
// {
// {1, 2, 3, 4},
// {1, 2, 3, 4},
// {1, 2, 3, 4},
// {1, 2, 3, 4},
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

void MatrixСhangeRowToString(int[,] array2d)
{   // Симметричную(!) таблицу  "разворачиваем" вокруг диагонали (по углу рекурсивно)
    for (int i = 0; i < array2d.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < array2d.GetLength(1); j++)
        {
            int temp = array2d[i, j];
            array2d[i, j] = array2d[j, i];
            array2d[j, i] = temp;
        }
    }
}

void Main()
{
    int[,] array2d = CreateMatrixRndInt(4, 4, -0, 9);
    if (array2d.GetLength(0) != array2d.GetLength(1))
    
        Console.WriteLine("  Некорректный массив (количество строк должно совпадать с количеством столбцов): ");
    else
    {
        Console.WriteLine();
        Console.WriteLine("Для массива: ");
        PrintMatrix(array2d);
        MatrixСhangeRowToString(array2d);
        Console.Write("Поменяли строки на столбцы: ");
        Console.WriteLine();
        PrintMatrix(array2d);
        Console.WriteLine();
    }
}


Main();
