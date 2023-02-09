/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] MatrixComposition(int[,] matrix, int[,] otherMatrix, int rows, int cols)
{
    int[,] resMatr = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < otherMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < resMatr.GetLength(1); k++)
            {
                resMatr[i,j] += matrix[i,k] * otherMatrix[k,j];
            }
        }
    }
    return resMatr;
}

int[,] matrix = { { 2, 4 }, { 3, 2 } };
System.Console.WriteLine("Первая матрица:");
PrintMatrix(matrix);
System.Console.WriteLine();

int[,] otherMatrix = { { 3, 4 }, { 3, 3 } };
System.Console.WriteLine("Вторая матрица:");
PrintMatrix(otherMatrix);
System.Console.WriteLine();

int[,] resultMatrix = MatrixComposition(matrix, otherMatrix, 2, 2);

System.Console.WriteLine("Произведение двух матриц:");
PrintMatrix(resultMatrix);
System.Console.WriteLine();
System.Console.WriteLine("===================================================================================================");
System.Console.WriteLine();

// Вариант решения с рандомными матрицами

int rows = PrintNumber("Введите количество строк: ");
int cols = PrintNumber("Введите количество столбцов: ");
System.Console.WriteLine();

int[,] randomMatrix = FillMatrix(rows, cols);
System.Console.WriteLine("Первая матрица:");
PrintMatrix(randomMatrix);

System.Console.WriteLine();

int[,] otherRandomMatrix = FillMatrix(rows, cols);
System.Console.WriteLine("Вторая матрица:");
PrintMatrix(otherRandomMatrix);

int[,] resultRandomMatrix = MatrixComposition(randomMatrix, otherRandomMatrix, rows, cols);

System.Console.WriteLine();
System.Console.WriteLine($"Произведение двух матриц: ");
PrintMatrix(resultRandomMatrix);