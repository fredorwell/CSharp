﻿/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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


void PrintMatrixInt(int[,] matrix)
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

void PrintArray(double[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}| ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("|");
}

double[] averagColumns(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[i] += matrix[j, i];
        }
        result[i] = Math.Round(result[i] / matrix.GetLength(0), 2);
    }
    return result;
}
int[,] array2D = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrixInt(array2D);
Console.WriteLine();
double[] res = averagColumns(array2D);
Console.WriteLine("Среднее арифмитическое столбцов: ");
PrintArray(res);

