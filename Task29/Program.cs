// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
MakeArrey(array);
PrintArray(array);


void MakeArrey(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        // return arr;
    }
}

void PrintArray(int[] arr)
{
    Console.Write("Для введенных значений: ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write(" -> ");

    Console.Write("Массив: [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write("]");
}
