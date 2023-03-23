// Задача 57:
// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// Стратегия: 
// 1. двумерный массив транформировать в одномерный;
// 2. одномерный массив сортировать по возрастанию, 
//    используя метод (void)  Array.Sort(array);
// 3. считать повторения одним(!) проходом.

int[,] array2d = new int[,]
{
{0, 2, 3, 4},
{1, 2, 3, 4},
{1, 2, 3, 4},
{1, 2, 3, 5},
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

void PrintMatrixUsers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" Символ (число) ");
        Console.Write($"{matrix[i, 0],2}");
        Console.Write("  встречается ");
        Console.Write($"{matrix[i, 1],2}");
        Console.Write("  раз");
        Console.WriteLine();
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

int[] Array2dToArray1d(int[,] array2d)
{
    int numRows = array2d.GetLength(0);
    int numColm = array2d.GetLength(1);
    int[] array1d = new int[numRows * numColm];
    // int[] array1d = new int[array2d.Length];
    int k = 0;
    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numColm; j++)
        {
            array1d[k] = array2d[i, j];
            k++;
        }
    }
    return array1d;
}

int NumberUniqElem(int[] array1d)
{
    int k = 0;
    int temp = 0;
    int i = 0;
    while (i < array1d.Length)
    {
        k++;
        temp = array1d[i];
        int q = 0;
        for (int j = 0; i + j < array1d.Length; j++)
        {
            if (temp == array1d[i + j])
            {
            q++;
            }
        }
        i = i + q;
    }
    return k;

}

int [,] CreateFreqArray(int[] array1d, int numUneq)
{
    int[,] freqArray = new int[numUneq,2];
    int temp = 0;
    int i = 0;
    int k = 0;
    while (i < array1d.Length)
    {
        temp = array1d[i];
        int q = 0;
        for (int j = 0; i + j < array1d.Length; j++)
        {
            if (temp == array1d[i + j])
            q++;
        }
        freqArray[k,0] = temp;
        freqArray[k,1] = q;
        k = k + 1;
        i = i + q;
    }
    return freqArray;


}


void Main()
{
    // int[,] array2d = CreateMatrixRndInt(5, 5, -0, 9);
    Console.WriteLine("  Элементы двумерного массива: ");
    PrintMatrix(array2d);
    Console.WriteLine("  конвертированы в одномерный массив: ");
    int[] array1d = Array2dToArray1d(array2d);
    PrintArray1d(array1d);
    Console.WriteLine();
    Console.WriteLine("  выполнена сортировка: ");
    Array.Sort(array1d);
    PrintArray1d(array1d);
    int numUniq = NumberUniqElem(array1d);
    Console.WriteLine();
    Console.WriteLine($"  Количество уникальных элементов: {numUniq}");
    Console.WriteLine("  Частотный массив: ");
    int [,] freqArray = CreateFreqArray(array1d, numUniq);
    PrintMatrix(freqArray);
    Console.WriteLine("  Частотный массив Пользователя: ");
    PrintMatrixUsers(freqArray);
}

Main();
