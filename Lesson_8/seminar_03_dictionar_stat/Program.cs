/*
Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
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

int MaxMatrix(int[,] matrix)
{
    int MaxResult = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > MaxResult) MaxResult = matrix[i, j];
        }
    }
    return MaxResult;
}
int MinMatrix(int[,] matrix)
{
    int MinResult = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < MinResult) MinResult = matrix[i, j];
        }
    }
    return MinResult;
}

void dictStat(int[,] matrix)
{

    int maxValue = MaxMatrix(matrix);
    int minValue = MinMatrix(matrix);
    for (int value = minValue; value <= maxValue; value++)
    {
        int result = default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == value) result++;
            }
        }
        if (result != 0) Console.WriteLine($"Число {value} встречается {result} раз");
    }
}



int[,] array2D = CreateMatrixRndInt(15, 15, 5, 9);
PrintMatrix(array2D);
Console.WriteLine();
dictStat(array2D);