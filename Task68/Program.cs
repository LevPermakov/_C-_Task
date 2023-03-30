// Задача 68: 
// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

//                               n + 1, если m = 0;
// Алгоритм вычисления А(m,n)    A(m-1, 1), если m != 0, n = 0;
//                               A(m-1, A(m, n - 1), если m > 0, n > 0.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int FunAkkerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return FunAkkerman(m - 1, 1);
    else
      return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
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
    int number1 = UserInput("Введите Первое целое положительное число m: ");
    int number2 = UserInput("Введите Второе целое положительное число n: ");
    int num = FunAkkerman(number1, number2);
    Console.Write($"значение функции Аккермана: A({number1},{number2}) = {num}");
}

Main ();


