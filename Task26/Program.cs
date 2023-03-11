// Задача 26: 
// Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе. 

// 456 -> 3 
// 78 -> 2 
// 89126 -> 5

Console.Write("Введите целое положительное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int decimalDigit = DecimalDigit(numberN);
Console.Write($"{numberN} -> {decimalDigit}");


int DecimalDigit(int num)
{
    int digit10= 0;
    while (num != 0)
    {
        num = num / 10;
        digit10 ++;
    }
    return digit10;
}