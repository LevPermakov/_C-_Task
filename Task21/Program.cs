// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты X для 1-й точки: ");
Console.Write("Точка А X1:  ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y для 1-й точки: ");
Console.Write("Точка А Y1:  ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z-й точки: ");
Console.Write("Точка А Z1:  ");
int zA = Convert.ToInt32(Console.ReadLine());
//-------------------------------------------------------
Console.WriteLine("Введите координаты X для 2-й точки: ");
Console.Write("Точка B X2:  ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y для 2-й точки: ");
Console.Write("Точка B Y2:  ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z для 2-й точки: ");
Console.Write("Точка B Z2:  ");
int zB = Convert.ToInt32(Console.ReadLine());

double length = Length(xA, yA, zA, xB, yB, zB);
length = Math.Round(length, 2, MidpointRounding.ToZero);

string result = length > 0 ? 
        $"Расстояние между указанными координатами: {length}"
        : "Введены некорректные координаты.";
Console.WriteLine(result);

double Length(int x1, int y1, int z1, int x2, int y2, int z2)
{
    //***** фиксируем плоскость min(X)
    int Xmin = 0;
    if (x1 > x2) Xmin = x2; else { Xmin = x1; }
    //***** вычисляем гипотенузу в плоскос min(X)
    int lengthKx = x2 - x1;
    int lengthKy = y2 - y1; 
    double lengthKz = z2 - z1;
    if ( lengthKx < 0) lengthKx = -lengthKx;  
    if ( lengthKy < 0) lengthKy = -lengthKy;  
    if ( lengthKz < 0) lengthKz = -lengthKz;  
    double lengthGipXmin = Math.Sqrt(lengthKy * lengthKy + lengthKz * lengthKz);
    //***** вычисляем гипотенузу в плоскости Z (найденная гипотенуза_Z стала катетом_Z)
    lengthKz = lengthGipXmin;
    double lengthGip = Math.Sqrt(lengthKx * lengthKx + lengthKz * lengthKz);
    return lengthGip;
}