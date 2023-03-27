// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[,,] Create3dArrayRndInt(int rows, int colums, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, colums, depth];
    if (rows * colums * depth > max - min)
    {
        Console.WriteLine("Ошибка! Количество элементов массива превышает количество значений заданного интервала.");
    }
    else
    {
        // Random rnd = new Random();
        int value = min;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    // matrix[i, j, k] = rnd.Next(min, max + 1);
                    matrix[i, j, k] = value;
                    value++;
                }
            }
        }
    }
    return matrix;
}


void Print3dArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.WriteLine($"{array3d[i, j, k],3}({i},{j},{k}) ");
            }


        }
    }
}



void Main()
{
    int[,,] array3D = Create3dArrayRndInt(3, 4, 7, 10, 99);
    Console.WriteLine();
    if (array3D[0,0,0] != 0)
    {
        Console.WriteLine("3D массив:");
        Print3dArray(array3D);
    }
}

Main();
