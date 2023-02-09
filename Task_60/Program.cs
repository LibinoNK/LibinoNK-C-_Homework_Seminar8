// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Fill3DMatrix(int rows, int cols, int depth)
{
    int[,,] matr = new int[rows, cols, depth];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                matr[i, j, k] = rand.Next(10, 100);
            }    
        }
    }
    return matr;
}

void Print3DMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
            System.Console.Write(matr[i, j, k]+ $"({i}, {j}, {k})" + "\t");
            }
        System.Console.WriteLine();
        }
    }
}

int[,,] matrix3D = Fill3DMatrix(2, 2, 2);
Print3DMatrix(matrix3D);