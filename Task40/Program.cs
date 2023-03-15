// Задача 40: 
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины. 

// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.


bool TestTriangle(int sizeA, int sizeB, int sizeC)
{
    if ( (sizeA < sizeB + sizeC) && (sizeB < sizeA + sizeC) && (sizeC < sizeB + sizeA) )
    return true;
    return false;
}


void Main()
{
Console.Write("Введите длину 1-й стороны треугольника (целое число): ");
int sizeA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину 2-й стороны треугольника (целое число): ");
int sizeB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину 3-й стороны треугольника (целое число): ");
int sizeC = Convert.ToInt32(Console.ReadLine());
bool answer = TestTriangle(sizeA, sizeB, sizeC);
Console.WriteLine(answer ? "Да" : "Нет");
}

Main();