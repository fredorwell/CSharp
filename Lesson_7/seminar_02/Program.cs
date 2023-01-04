/*
Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Amn = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5

*/

int[,] CreateMatrixSumIndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            matrix[i, j] = i +j;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

Console.Write("Введите количество строк в вашей матрце: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в вашей матрце: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixSumIndInt(m, n);
PrintMatrix(array2D);