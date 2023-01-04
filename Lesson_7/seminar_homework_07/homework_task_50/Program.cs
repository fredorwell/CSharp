/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

int IndexSearch(int[,] matrix, int searchI, int searchJ)
{
    int result = -1;
    if (searchI <= matrix.GetLength(0) && searchJ <= matrix.GetLength(1)) result = matrix[searchI,searchJ];
    return result;
}
void InterpSearchResult (int resultSearch, int searchI, int searchJ)
{
    if (resultSearch != -1) Console.WriteLine($"Элемента с индексами {searchI}, {searchJ} равен {resultSearch} ");
    else Console.WriteLine($"Элемента с индексами {searchI}, {searchJ} не существует ");
    
}


int[,] array2D = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(array2D);
Console.Write($"Введите номер строки: ");
int searchRow = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите номер столбца: ");
int searchColl = Convert.ToInt32(Console.ReadLine());
int res = IndexSearch(array2D, searchRow, searchColl);
InterpSearchResult(res, searchRow, searchColl);
