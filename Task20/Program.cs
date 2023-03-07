// Задача 20.
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B(2,1) -> 5.09
// A (7,-5); B(1;-1) -> 7.21


Console.WriteLine("Введите координаты X для 1-й точки: ");
Console.Write("Точка А X1:  ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y для 1-й точки: ");
Console.Write("Точка А Y1:  ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X для 2-й точки: ");
Console.Write("Точка B X2:  ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y для 2-й точки: ");
Console.Write("Точка B Y2:  ");
int yB = Convert.ToInt32(Console.ReadLine());


double length = Length(xA, yA, xB, yB);
length = Math.Round(length, 2, MidpointRounding.ToZero);

string result = length > 0 ? 
        $"Расстояние между указанными координатами: {length}"
        : "Введены некорректные координаты.";
Console.WriteLine(result);

double Length(int x1, int y1, int x2, int y2)
{
    //Console.WriteLine($"A ({x1},{y1}); B({x2},{y2})");
    int lengthK1 = x2 - x1; 
    int lengthK2 = y2 - y1;
    if ( lengthK1 < 0) lengthK1 = -lengthK1;  
    if ( lengthK2 < 0) lengthK2 = -lengthK2;  
    //Console.WriteLine($"Длина первого катета: {lengthK1}, длина второго катета: {lengthK2}");
    double lengthGip = Math.Sqrt(lengthK1 * lengthK1 + lengthK2 * lengthK2);
    //Console.WriteLine($"Длина гипотенузы: {lengthGip}");
    //double dRound = Math.Round(lengthGip, 2, MidpointRounding.ToZero);
    //Console.WriteLine($"Длина гипотенузы: {dRound}");
    return lengthGip;
}