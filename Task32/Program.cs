// Задача 32: 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Write("Введите размерность массива (целое положительное число): ");
int numberArr = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(numberArr, -9, 9);
Console.Write(" Для массива:              ");
PrintArray(array);
EditArray (array);
Console.Write(" инвертированный массив -> ");
PrintArray(array);




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

void EditArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    // return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

