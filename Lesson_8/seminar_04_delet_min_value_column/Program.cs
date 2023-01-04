/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} | ");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}
int[] MinMatrixInd(int[,] matrix)
{
    int Min = matrix[0, 0];
    int[] resultIndex = { 0, 0 };
    int minValue = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue)
            {
                minValue = matrix[i, j];
                resultIndex[0] = i;
                resultIndex[1] = j;
            }
        }
    }
    return resultIndex;
}
void PrintMatrixWithoutMin(int[,] matrix, int[] minIndex)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != minIndex[0])
        {

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != minIndex[1])
                {
                    if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} | ");
                    else Console.Write($"{matrix[i, j],2} ");

                }

            }
            Console.WriteLine();
        }
    }
}

int[,] DeleteMinRowsColumn(int[,] matrix, int[] minIndex)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int i1 = 0;
    int j1 = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        
        if (i1 == minIndex[0])i1++;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (j1 == minIndex[1])j1++;
            result[i,j] = matrix[i1,j1];
            j1++;
        }
        i1++;
        j1 = 0;
    }
    return result;
}

int[,] array2D = CreateMatrixRndInt(5, 5, 0, 50);
PrintMatrix(array2D);
Console.WriteLine();
int[] minIndexArr = MinMatrixInd(array2D);
Console.WriteLine("Удаление через печать");
PrintMatrixWithoutMin(array2D, minIndexArr);
Console.WriteLine("Удаление через удаление");
int[,] resulArr = DeleteMinRowsColumn(array2D, minIndexArr);
PrintMatrix(resulArr);
