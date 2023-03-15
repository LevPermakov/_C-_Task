// Задача 39: 
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.) 
// [1 2 3 4 5] -> [5 4 3 2 1] 
// [6 7 3 6] -> [6 3 7 6]

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

void ReverseArray(int[] arr)
{
    // Array.Reverse(array);
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 -i];
        arr[arr.Length - 1 -i] = temp;
    }
}

void Main()
{
Console.Write("Введите размерность массива (целое положительное число): ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(sizeArr, 0, 9);
Console.Write(" Исходный массисв: ");
PrintArray(array);
ReverseArray(array);
Console.Write(" реверс (разворот) массива -> ");
PrintArray(array);
// Array.Reverse(array);
// PrintArray(array);
}

Main();