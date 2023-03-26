// Задача 69:
// Напишите программу, которая не вход принимает два числа A и B,
// в возводит число A в целую степень B с помощью рекурсии.
// A = 3; B = 5  -> 243 (3 в 5)
// A = 2; B = 3  -> 8



int Number1InRaiseNumber2(int a, int b)
{
    if (b == 0) return 1;
    else return a * Number1InRaiseNumber2(a, b - 1);
    // else return checked (a * Number1InRaiseNumber2(a, b - 1));   // проверка на переполнение типа
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
    int number1 = UserInput("Введите Первое целое положительное число A: ");
    int number2 = UserInput("Введите Второе целое положительное число B: ");
    int num = Number1InRaiseNumber2(number1, number2);
    Console.Write(num);
}

Main ();