/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} | ");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}

int[,] CreateMatrixSpiralInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    int i = 0;
    int j = 0;
    int num = 1;

    for (j = 0; j < matrix.GetLength(0); j++)
    {
        matrix[i, j] = num;
        num++;
    }
    for (i = 1; i < matrix.GetLength(0); i++)
    {
        j = matrix.GetLength(0) - 1;
        matrix[i, j] = num;
        num++;
    }
    for (j = matrix.GetLength(0) - 2; j >= 0; j--)
    {
        i = matrix.GetLength(0) - 1;
        matrix[i, j] = num;
        num++;
    }
    for (i = matrix.GetLength(0) - 2; i >= 1; i--)
    {
        j = 0;
        matrix[i, j] = num;
        num++;
    }
    for (j = 1; j < matrix.GetLength(0) - 1; j++)
    {
        i = 1;
        matrix[i, j] = num;
        num++;
    }
    for (j = matrix.GetLength(0) - 2; j >= 1; j--)
    {
        i = matrix.GetLength(0) - 2;
        matrix[i, j] = num;
        num++;
    }
    return matrix;
}

int[,] array2D = CreateMatrixSpiralInt(4, 4);
PrintMatrix(array2D);

