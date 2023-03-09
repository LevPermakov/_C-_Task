// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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
    int sq = num * num * num;
    string str = $"{num,4}   {sq,4}"; return str;
}
