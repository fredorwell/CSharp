/*
Дан массив. Необходимо отсортировать его от меньшего к большему
*/

void printArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int[] arr = { 1, 5, 8, 4, 5, 4, 9, 11, 10 };
printArray(arr);
SelectionSort(arr);
printArray(arr);