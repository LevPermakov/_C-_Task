// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


bool TestInput(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2) {Console.WriteLine(" Значения некорректны. При k1=k2 и b1=b2 прямые совпадают."); return false; }
    if (k1 == k2 && b1 != b2) {Console.WriteLine(" Значения некорректны. При k1=k2 прямые параллельны и не пересекаются."); return false; }
    return true;
}


void Main()
{
    Console.WriteLine("Для определения точки пересечения прямых, соответствующих уравненям:");
    Console.WriteLine(" y = k1 * x + b1");
    Console.WriteLine(" y = k2 * x + b2");
    Console.Write(" Введите значение b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write(" Введите значение k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write(" Введите значение b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write(" Введите значение k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    bool result = TestInput(b1, k1, b2, k2);
    if (result == true)
    {
        // в точке пересечения прямых y=y, 
        // тогда: (k1-k2)x = b2-b1;    x = (b2-b1)/(k1-k2);
        // при этом значении x, y=k1*x + b1;
        double koordX = (b2 - b1) / (k1 - k2);
        double koordY = k1 * koordX + b1;
        koordX = Math.Round(koordX, 2, MidpointRounding.ToZero);
        koordY = Math.Round(koordY, 2, MidpointRounding.ToZero);
        Console.WriteLine($" Прямые пересекутся в точке с координатами: ({koordX}; {koordY})");
    }
}

Main();