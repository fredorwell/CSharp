/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int[] MultupliArrayValue(int[] array)
{
    int len = array.Length;
    int sizeResult = len / 2;
    if (len % 2 == 1) sizeResult++;

    int[] result = new int[sizeResult];

    for (int i = 0; i < sizeResult; i++)
    {
        result[i] = array[i] * array[(array.Length - 1) - i];
    }

    if (len % 2 == 1) { result[len / 2] = array[len / 2]; }
    
    return result;
}

//int[] arr = CreateArrayRndInt(10, 1, 150);
int[] arr1 = { 1, 2, 3, 4, 5 };
PrintArray(arr1);
int[] result1 = MultupliArrayValue(arr1);
PrintArray(result1);

int[] arr2 = { 6, 7, 3, 6 };
PrintArray(arr2);
int[] result2 = MultupliArrayValue(arr2);
PrintArray(result2);


