// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите целое положительное число (A): ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое положительное число (B) - степень A: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int maltiA = ARateMaltiB (numberA, numberB);
PrintAnswer (numberA, numberB, maltiA);


int ARateMaltiB (int numA, int numB)
{
    int numR = numA;
    for (int i = 1; i < numB; i++)  
    {
        numR = numR * numA;  
    }
    return numR;
}

void PrintAnswer(int numbA, int numbB, int maltA)
{
    Console.WriteLine($"{numbA} в степни {numbB} -> {maltA}");
}
