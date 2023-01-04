/*
Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int SummMainDiag(int[,] matrix)
{
    int result = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) result = result + matrix[i, j];
        }
    }
    return result;
}

int SummMainDiag2(int[,] matrix)
{
    int result = default;
    int maxSize = default;
    if (matrix.GetLength(0) < matrix.GetLength(1)) maxSize = matrix.GetLength(0);
    else maxSize = matrix.GetLength(1);
    for (int i = 0; i < maxSize; i++)
    {
        result = result + matrix[i, i];
    }
    return result;
}


int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
int summArr = SummMainDiag(array2D);
Console.WriteLine($"Сумма элементов на гл. диагонали: {summArr}");
int summArr2 = SummMainDiag2(array2D);
Console.WriteLine($"Сумма элементов на гл. диагонали: {summArr2}");
