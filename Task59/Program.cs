// Задача 59:
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
// на пересечени которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим массив:
// 9 2 3
// 4 2 4 
// 2 6 7
// Если колич. наименьших эл-в - несколько, 
// то взять 1-й или последний (в зависимости от алгоритма - первое вхождение).



// int[,] array2d = new int[,]
// {
// {1, 2, 3, 4},
// {1, 2, 5, 4},
// {7, 2, 4, 8},
// {6, 2, 4, 0},
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

void PrintArray1d(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write("]");
}

int[] HuntMinValIn2d(int[,] array)
{
    int[] indMin = new int[2];
    int iInd = 0;
    int jInd = 0;
    int minVal = Int32.MaxValue;
    int arrRows = array.GetLength(0);
    int arrCols = array.GetLength(1);
    for (int i = 0; i < arrRows; i++)
    {
        for (int j = 0; j < arrCols; j++)    
        {
            if (array[i, j] < minVal)         // для первого вхождения знак: < ; для последнего вхождения знак: <=
            {
                minVal = array[i, j];
                iInd = i;
                jInd = j;
            }
        }
    }
    indMin[0] = iInd;
    indMin[1] = jInd;
    return indMin;
    // return new int[] {iInd, jInd};
}

int[,] DeletRowAndColOnIndex(int[,] array2d, int[] arrayInd)
{
    int[,] arrNew = new int[array2d.GetLength(0) - 1, array2d.GetLength(1) - 1];
    if (arrayInd[0] > array2d.GetLength(0))
    {
        Console.WriteLine("  Ошибка! Номер удаляемой стороки больше числа строк исходнного массива.");
        // корректно выйти
    }
    if (arrayInd[1] > array2d.GetLength(1))
    {
        Console.WriteLine("  Ошибка! Номер удаляемого столбца больше числа столбцов исходнного массива.");
        // корректно выйти
    }
    else
    {
        int iIndNew = 0;
        for (int i = 0; i < array2d.GetLength(0); i++)
        {
            if (i != arrayInd[0])
            {
                int jIndNew = 0;
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    if (j != arrayInd[1])
                    {
                        arrNew[iIndNew, jIndNew] = array2d[i, j];
                        jIndNew++;
                    }
                }
                iIndNew++;
            }
        }
    }
    return arrNew;
}


void Main()
{
    int[,] array2d = CreateMatrixRndInt(5, 5, 0, 9);
    Console.WriteLine("  Исходный массив: ");
    PrintMatrix(array2d);
    int[] indexMin = HuntMinValIn2d(array2d);
    Console.WriteLine("  Позиция наименьшего элемента в массиве: ");
    PrintArray1d(indexMin);
    Console.WriteLine();
    int[,] arrayNew = DeletRowAndColOnIndex(array2d, indexMin);
    Console.WriteLine();
    Console.WriteLine("  Исключаем строку и столбец с минимальным значением: ");
    PrintMatrix(arrayNew);
}

Main();
