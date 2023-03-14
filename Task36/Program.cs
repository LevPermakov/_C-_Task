// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int NotEvenPosSumNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0 ) count = count + arr[i];
    } 
    return count;
}

int[] CreateArrayRndInt(int number, int min, int max)
{
    int[] arr = new int[number];
    Random rnd = new Random();
    for (int i = 0; i < number; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


void Main()
{
Console.Write("Введите размерность массива (целое положительное число): ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(sizeArr, -99, 99);
int notEvenPosSumNumbers = NotEvenPosSumNumbers(array);
Console.Write(" В массиве: ");
PrintArray(array);
Console.Write($" сумма элементов, стоящих на нечетных позициях -> {notEvenPosSumNumbers}");
}

Main();
