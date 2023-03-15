// Задача 44:
// Не используя рекурсию, 
// выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

// Если N=5 -> 01123
// Если N=3 -> 011
// Если N=7 -> 0112358


// int ch1 = 0;
// int ch2 = 1;
// int ch3 = 0;

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

int[] CreatSeqFibonachi(int num)
// string CreatSeqFibonachi(int num)
{
    int[] array = new int[num];    // реализация через массив
    array[0] = 0;
    array[1] = 1;
    
    // string str = 0 + String.Empty;
    // str = str + " " + 1;
    // int ch1 = 0;
    // int ch2 = 1;
    // int ch3 = 0;
    // for (int i = 2; i <= num -2; i++)
    for (int i = 2; i <= num - 1; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
        // ch3 = ch1 + ch2;
        // str = str + " " + ch3; 
        // ch1 = ch2;
        // ch2 = ch3;
    }
    // return str;
    return array;
}


void Main()
{
    Console.Write("Введите целое положительное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int[] result = CreatSeqFibonachi(number);
    PrintArray(result);
    // string result = CreatSeqFibonachi(number);
    // Console.Write($" последовательность Фибоначчи: -> {result}");
    //   double goldSize = ch3 / ch2;    // показать дробную часть (1,618...) - все в double (округлить)
    // double goldSize = result[number - 1] / result[number - 2];
    // Console.Write($"   Золотое сечение: -> {goldSize}");
}

Main();