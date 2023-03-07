// Task17
// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), 
// причем X не=0 и Y не=0 
// и выдает номер четверти плоскости, 
// в которой находится эта точка. 
// 1:  x > 0, y > 0
// 2:  x < 0, y > 0
// 3:  x < 0, y < 0
// 3:  x > 0, y < 0

Console.WriteLine("Введите координаты точки: ");
Console.Write("X:  ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:  ");
int yCoord = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoord, yCoord);
string result = quarter > 0 ? 
        $"Указанные координаты соответствуют четверти - {quarter}"
        : "Введены некорректные координаты.";

Console.WriteLine(result);

int Quarter(int x, int y)
{
    if (x > 0  && y > 0) return 1;
    if (x < 0  && y > 0) return 2;
    if (x < 0  && y < 0) return 3;
    if (x > 0  && y < 0) return 4;
    return 0;
}