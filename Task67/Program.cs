// Задача 67:
// Напишите программу, которая будет принимать на вход 
// число и возвращать сумму его цифр.
// 453 -> 12
// 45  -> 9

int number = UserInput("Введите целое положительное число: ");
int num = SumNumberDigits(number);
Console.Write(num);

int SumNumberDigits(int num)
{
    if(num == 0) return 0;
    else return num % 10 + SumNumberDigits(num / 10);
}

int UserInput (string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}