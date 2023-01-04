// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
int[] array = {21, 2122, 48, 4, 4125, 164, 17, 48};

int n = array.Length;
int find = 48;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}
