// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find. Реализовать поиск и заполнение массива необходимо через методы.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}
void PrineArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{collection[index]} ");
        index++;
    }
}
int IndexOf(int[] collection, int find)
{
    int length = collection.Length;
    int index = 0;
    int find_position = -1;
    while (index < length)
    {
        if (collection[index] == find)
        {
            find_position = index;
            break;
        }
        index++;
    }
    return find_position;
}

int[] array = new int[10];
FillArray(array);
PrineArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

/*
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

*/