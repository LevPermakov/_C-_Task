// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
//** если введен символ (не число) или "пустой" ввод - необрабатываемое прерывание
if (number1 >= number2 && number2 > 0)
{
    //int result = Convert.ToInt32(number1 % number2);
    int result = Multiple(number1, number2);
    //Console.WriteLine(result);
    if (result == 0)
    {
        Console.WriteLine($"{number1}, {number2} -> кратно");
    }
    else
    {
        Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {result}");
    }
}
else
{
    if (number2 == 0)
    {
        //Console.WriteLine(number2);
        Console.WriteLine("Ошибка. Второе число должно быть > 0.");
    }
    else
    {
        Console.WriteLine("Ошибка. Первое число должно быть >= второго числа.");
    }
}

//**********************************************************

int Multiple(int num1, int num2)
{
    return num1 % num2;
}