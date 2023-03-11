// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// По задаче 19 
// универсальное рабочее решение. 
// Очень усложнено, количество цифр нет необходимости определять, и, 
// тем более, не нужен вложенный цикл. 
// Достаточно одного цикла и две строки кода для разворота числа.

Console.Write("Введите целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int reversN = ReversNumber(numberN);
bool anser = Poliandr(numberN, reversN);
if (anser == true)
Console.Write($"{numberN} -> да");
else
{
    Console.Write($"{numberN} -> нет");
}


bool Poliandr (int numN, int revN)
{
    if (numN == revN) 
    return true;
    return false;
}

int ReversNumber(int num)
{
    //******* определяем значность num (для произвольного количества чисел)
    int numCopy = num;
    int degree10 = 0;
    while (numCopy > 9)
    {
        int rest = numCopy % 10;
        if (rest >= 0)
        {
            numCopy = numCopy / 10;
            degree10 ++;
        }
    }
    int numR = 0;
    int x = 0;
    int numAll = 0;
    int index = degree10 + 1;
    //******* revers 
    while (index > 0)
    {
        numR = num % 10;
        x = index - 1;
        while (x > 0)
        {
            numR = numR * 10;
            x --;
        }
        numAll = numAll + numR;
        num = num / 10;
        index --;
    }
    return numAll;
}