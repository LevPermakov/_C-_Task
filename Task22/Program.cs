// Задача 22.
// Напишете программу, которая 
// принимает на вход число (N) 
// и выдает таблицу квадратов чисел от 1 до N.

// 5 -> 
// 1   1
// 2   4
// 3   9
// 4  16
// 5  25


Console.Write("Введите целое положительное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN < 0) Console.WriteLine($"Введено некорректное число: {numberN}");
else
{
    Console.WriteLine($"{numberN} ->");
    int index = 1;
    while (index <= numberN)
    {
        Console.WriteLine(NumAndSquare(index));
        index++;
    }
}


string NumAndSquare(int num)
{
    int sq = num * num;
    string str = $"{num,4}   {sq,4}"; return str;
}

