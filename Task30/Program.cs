// Задача 30.
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,0,1,1]

int[] array = new int[8];
MakeRndArrey (array);
PrintArray (array);



void MakeRndArrey(int[] arr)
{
    Random rand = new Random ();  // Объект, как экземпляр класса (вне цикла)
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0,2);
    }
    // return array;
}

void PrintArray (int[] arr)
{
    Console.Write("Массив: [");
    for (int i = 0; i < arr.Length -1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}");
    Console.Write("]");
}
