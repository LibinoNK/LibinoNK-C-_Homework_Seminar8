/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
    return matr;
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

int PrintNumber(string text)
{
    System.Console.WriteLine(text);
    int num = System.Convert.ToInt32(System.Console.ReadLine());
    return num;
}

int[,] ArrangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j+1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i,j] < matrix[i,k])
                {
                    int temp = matrix[i,k];
                    matrix[i,k] = matrix[i,j];
                    matrix[i,j] = temp;
                }
            }
        }
    }
    return matrix;
}

int rows = PrintNumber("Введите количество строк: ");
int cols = PrintNumber("Введите количество столбцов: ");
System.Console.WriteLine();

int[,] matrix = FillMatrix(rows, cols);
System.Console.WriteLine("Заданный массив:");
PrintMatrix(matrix);

System.Console.WriteLine();

int[,] matr = ArrangeMatrix(matrix);
System.Console.WriteLine("Массив со строками по убыванию:");
PrintMatrix(matr);

