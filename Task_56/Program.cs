/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

int SmallestAmountInRow(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }

    System.Console.WriteLine();
    System.Console.WriteLine("Cумма элементов строк: " + string.Join(", ", array));
    System.Console.WriteLine();

    int minIdx = 0;
    for (int i = 0; i < array.Length-1; i++)
    {   
        int j = i+1;
        if (array[i] > array[j])
        {
            minIdx = j;
        }
    }
    int numberOfRow = minIdx + 1;
    return numberOfRow;
}

int[,] matrix = FillMatrix(3, 4);
System.Console.WriteLine("Заданный массив:");
PrintMatrix(matrix);

System.Console.WriteLine($"Наименьшая сумма элементов в {SmallestAmountInRow(matrix)} строке");