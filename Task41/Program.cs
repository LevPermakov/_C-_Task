// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int ResultNumb(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count += 1;
    }
    return count;
}

void Main()
{
Console.Write("Введите количество чисел (целое положительное число): ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArr];
int elmArr = 0;
for (int i = 0; i < sizeArr; i++)
{
    Console.Write($"Введите {i+1}-е число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int resultNumb = ResultNumb(array);
Console.Write($" Вы ввели {resultNumb} положительных числа.");
}

Main();
