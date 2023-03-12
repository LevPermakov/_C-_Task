// Задача 27: 
// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целое положительное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int sumNumb = SumNumb (numberA);
PrintSumNumb (numberA, sumNumb);


int SumNumb (int numA)
{
    int numResult = 0;
    int numRest = 0;
    while (numA > 0)
    {
        numRest = numA % 10;
        numResult = numResult + numRest;
        numA = numA / 10;
    }
    return numResult;
}

void PrintSumNumb(int numbA, int sumA)
{
    Console.WriteLine($"Сумма цифр в числе: {numbA} -> {sumA}");
}
