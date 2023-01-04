/*
Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
*/

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


int GetSumPositive(int[] array)
{
    int sumPositive = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
    }
    return sumPositive;
}

int GetSumNegative(int[] array)
{
    int sumNegative = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
    }
    return sumNegative;
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
Console.WriteLine($"Суммма положительных элементов {GetSumPositive(arr)}, сумма отрицательных значений: {GetSumNegative(arr)}");
