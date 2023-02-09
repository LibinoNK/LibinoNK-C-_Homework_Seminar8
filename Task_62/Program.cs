// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= rows * cols)
    {
        matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < cols - 1)
        {
            j++;
        }
        else if (i < j && i + j >= rows - 1)
        {
            i++;
        }
        else if (i >= j && i + j > cols - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = FillMatrix(4, 4);
PrintMatrix(matrix);