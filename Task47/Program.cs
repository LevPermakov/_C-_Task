// Задача 47:
// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.
// Пример:
// 0,5   7 - 2    0,2
// 1 - 3,3   8 - 9,9
// 8     7,8 - 7,1  9


double[,] CreateMatrixRndDouble(int rows, int colums, int min, int max)
{
    double[,] matrix = new double[rows, colums];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            num = Math.Round(num, 2, MidpointRounding.ToZero);
            matrix[i, j] = num;
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 8} ");
        }
        Console.WriteLine("|");
    }
}


void Main()
{
    Console.Write("Введите количесво строк в массиве (целое положительное число): ");
    int sizeRows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количесво столбцов в массиве (целое положительное число): ");
    int sizeColums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение числа: ");
    int minNum = Convert.ToInt32(Console.ReadLine());
      Console.Write("Введите максимальное значение числа: ");
    int maxNum = Convert.ToInt32(Console.ReadLine());
    double[,] array2D = CreateMatrixRndDouble(sizeRows, sizeColums, minNum, maxNum);
    Console.WriteLine(" Массив сформирован: ");
    PrintMatrixDouble(array2D);
}

Main();
