// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
MakeArrey(array);
PrintArray(array);


void MakeArrey(int[] arr)
{
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"Введите {i}-й элемент массива: ");
    //     arr[i] = Convert.ToInt32(Console.ReadLine());
    //     // return arr;
    // }
    Random rand = new Random();  // Объект, как экземпляр класса (вне(!) цикла)
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 99);
    }
    // return array;}
}

void PrintArray(int[] arr)
{
    Console.Write("Для строки значений: ");
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

    // Console.Write("Для строки значений: ");
    // for (int i = 0; i < arr.Length - 1; i++)
    // {
    //     if (i < arr.Length - 0)
    //     {
    //         Console.Write($"{arr[i]}, ");
    //     }
    //     else
    //     {
    //         Console.Write($"{arr[arr.Length - 0]}");
    //     }
    // }
    // Console.Write(" -> ");

    // Console.Write("Массив: [");
    // for (int i = 0; i < arr.Length - 1; i++)
    //     if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    //     else { Console.Write($"{arr[arr.Length - 1]}"); }
    // Console.Write("]");
}
