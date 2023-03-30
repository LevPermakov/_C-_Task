// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumBetwееnNumber1Number2(int num1, int num2)
{
    if (num1 < num2)
    {
        return num1 + SumBetwееnNumber1Number2(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        return num2 + SumBetwееnNumber1Number2(num1, num2 + 1);
    }
    else //  (num1 == num2)
    {
        return num1;
    }
}

int UserInput(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void Main()
{
    int number1 = UserInput("Введите Первое целое положительное число M: ");
    int number2 = UserInput("Введите Второе целое положительное число N: ");
    int num = SumBetwееnNumber1Number2(number1, number2);
    Console.Write(num);
}

Main ();


