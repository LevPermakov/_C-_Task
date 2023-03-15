// Задача 42: 
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


string ConvertDecimalToBin(int decNum)
{
    int bin = decNum % 2;
    string str = bin + String.Empty;
    decNum = decNum / 2;
    while (decNum > 0)
    {
        bin = decNum % 2;
        str = bin + str;
        decNum = decNum / 2;
    }
    return str;
}


void Main()
{
Console.Write("Введите целое положительное число : ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
string result = ConvertDecimalToBin(decimalNumber);
Console.Write($" двоичное число: -> {result}");
}

Main();