// Задача 15: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Введите день недели (1-7): ");
int numberDay = Convert.ToInt32(Console.ReadLine());


if (numberDay < 1 || numberDay > 7)
{
    Console.Write($"Ошибка! День недели {numberDay} - не существует.");
}
else
{
    string day = NumberDay(numberDay);
    Console.Write($"-> {day}");
}

//=========================================================

string NumberDay(int numDay)
{
    string key = "Да";
    if (numDay == 1) key = "Нет";
    if (numDay == 2) key = "Нет";
    if (numDay == 3) key = "Нет";
    if (numDay == 4) key = "Нет";
    if (numDay == 5) key = "Нет";
    if (numDay == 6) key = "Да";
    if (numDay == 6) key = "Да";
    return key;  
}
