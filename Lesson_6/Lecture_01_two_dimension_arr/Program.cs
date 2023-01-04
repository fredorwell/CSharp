/*
Необходимо написать метод которой будет печатать двумерный массив и заполнять случайными числами от 1 до 9
*/


void PrintArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++) // GetLength(0) - кол-во строк
    {
        for (int column = 0; column < array.GetLength(1); column++)// GetLength(1) - кол-во столбцов
        {
            Console.Write($"{array[rows, column]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayRandInt(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++) // GetLength(0) - кол-во строк
    {
        for (int column = 0; column < array.GetLength(1); column++)// GetLength(1) - кол-во столбцов
        {
            array[rows,column] = new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArrayRandInt(matrix);
PrintArray(matrix);