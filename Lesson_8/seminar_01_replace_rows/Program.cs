﻿/*
Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.

Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
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

void ReplaceRows(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++) // 0 - rows  0 
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}
int[,] array2D = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(array2D);
ReplaceRows(array2D);
Console.WriteLine();
PrintMatrix(array2D);
