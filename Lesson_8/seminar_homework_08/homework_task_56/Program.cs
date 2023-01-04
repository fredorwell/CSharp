/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[] SummOfRows(int[,] matrix)
{
    int[] resultSumm = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resultSumm[i] += matrix[i,j];
        }
    }
    return resultSumm;
}
void MinSummRows(int[,] matrix)
{
    int[] summOfRows = SummOfRows(matrix);
    int minSumm = summOfRows[0];
    int minSummindex = 0;
    for (int i = 0; i < summOfRows.Length; i++)
    {
        if (summOfRows[i] < minSumm)
        {
            minSummindex = i;
            minSumm = summOfRows[i];
        }
    }
    Console.WriteLine($"Минимальная сумма элементов находится в строке {minSummindex + 1} и сумма равнна {minSumm}");
}

int[,] array2D = CreateMatrixRndInt(6, 4, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
MinSummRows(array2D);