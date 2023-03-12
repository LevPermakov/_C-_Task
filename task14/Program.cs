// 14. Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно 
// одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите целое число больше 0: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0)
{
    Console.WriteLine("Ошибка. Число должно быть > 0.");
}
else
{
    bool multiple = Multiple(number);
    //**** Через Тернарный оператор ***************
    // Console.WriteLine(multiple == true ? "Да" : "Нет");
    Console.WriteLine(multiple ? "Да" : "Нет");
}

bool Multiple(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
