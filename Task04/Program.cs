// Задача 4: 
// Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.
//
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[] { firstNumber, secondNumber, thirdNumber };
//int size = 3;
int size = (numbers.Length);
int numberMax = (numbers[0]);
int numberTmp;

for (int index = 1; index < size; index++)
{
    numberTmp = (numbers[index]);
    if (numberTmp > numberMax)
    {
        numberMax = numberTmp;
    }
    else {}
}
Console.WriteLine($"Максимальное число = {numberMax}.");