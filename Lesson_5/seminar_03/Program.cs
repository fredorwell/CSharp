/*
Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

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


void SearchNum(int[] arr,int arg)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == arg) result = 1;
    }
    if (result == 1) Console.Write($"В массиве есть цифра {arg}");
    else Console.Write($"В массиве нет цифры {arg}");

}
/*
int SearchNum(int[] arr, int arg)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == arg) result = 1;
    }
    return result;
}
*/

int[] array = { 6, 7, 19, 345, 3 };
int serchdig = 456;
PrintArray(array);
SearchNum(array, serchdig);
/*
int resultSearch = SearchNum(array, serchdig);
if (resultSearch == 1) 
{
    Console.Write($"В массиве есть цифра {serchdig}");
}
else 
{
    Console.Write($"В массиве нет цифры {serchdig}");
}
*/
