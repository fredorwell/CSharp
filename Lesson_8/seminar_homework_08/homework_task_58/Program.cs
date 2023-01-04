/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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


int[,] MultiplMatrix(int[,] matrixA, int[,] matrixB)
{
    //TODO проверка для умножения matrixA.GetLength(0) == matrixB.GetLength(1)
    int[,] ResultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    int temp = default;
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            temp = default;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                temp += matrixA[i, k] * matrixB[k, j];
            }
            ResultMatrix[i, j] = temp;
        }
    }
    return ResultMatrix;
}
bool MultiplMatrixCheck(int[,] matrixA, int[,] matrixB)
{
    bool result = false;
    if (matrixA.GetLength(1) == matrixB.GetLength(0)) result = true;
    return result;
}



int[,] matrixA = CreateMatrixRndInt(2, 3, 0, 10);
int[,] matrixB = CreateMatrixRndInt(3, 2, 0, 10);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrixA);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrixB);

if (MultiplMatrixCheck(matrixA, matrixB))
{
    int[,] multiMatrix = MultiplMatrix(matrixA, matrixB);
    Console.WriteLine();
    PrintMatrix(multiMatrix);
}
else
{
    Console.WriteLine("Матрицы текущих размеров нельзя перемножить =( ");
}