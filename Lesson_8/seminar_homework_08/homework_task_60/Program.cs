/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 
27(0,0,1) 
25(0,1,0) 
90(0,1,1)
34(1,0,0) 
26(1,0,1) 
41(1,1,0) 
55(1,1,1)
*/

/*
int[,,] CreateCubeRndInt(int rows, int columns, int deep, int min, int max)
{
    int[,,] cube = new int[rows, columns, deep];
    var rnd = new Random();

    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                cube[i, j, k] = rnd.Next(min, max);
            }
        }
    }
    return cube;
}
*/
void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{collection[index]} ");
        index++;
    }
}
int[,,] CreateCubeUniqInt(int rows, int columns, int deep, int min, int max)
{
    int[,,] cube = new int[rows, columns, deep];
    var rnd = new Random();
    bool checkUniq = false;
    int[] checkArray = new int[rows * columns * deep]; // массив для проверки уникальности
    int i1 = default; // счетчик массива для проверки уникальности
    int temp = default; // временная переменная для rnd.Next

    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                do
                {
                    temp = rnd.Next(min, max);
                    for (int l = 0; l < checkArray.Length; l++)
                    {
                        if (checkArray[l] == temp) checkUniq = true;
                        else checkUniq = false;
                        
                    }
                } while (checkUniq == true);
                cube[i, j, k] = temp;
                checkArray[i1] = temp;
                i1++;
            }
        }
    }
    Console.WriteLine();
    return cube;
}

void PrintCube(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        Console.WriteLine($"Разрез {i + 1} ");
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.WriteLine($"({i}, {j}, {k}) Значение = {array3D[i, j, k]}; ");
            }
        }

    }
}


int[,,] matrix3d = CreateCubeUniqInt(3, 3, 3, 10, 40);
PrintCube(matrix3d);