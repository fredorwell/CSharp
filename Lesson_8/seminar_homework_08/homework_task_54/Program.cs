/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


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
void SortBubble(int[,] marix)
{
    for (int i = 0; i < marix.GetLength(0); i++)
    {
    for (int j = 0; j < marix.GetLength(1); j++)
    {
        for (int k = 0; k < marix.GetLength(1) - 1; k++)
        {
            if (marix[i, k] < marix[i, k + 1])
            {
                int temp = marix[i, k];
                marix[i, k] = marix[i, k + 1];
                marix[i, k + 1] = temp;
            }
        }
    }
    }
}

int[,] array2D = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(array2D);
SortBubble(array2D);
Console.WriteLine();
PrintMatrix(array2D);
