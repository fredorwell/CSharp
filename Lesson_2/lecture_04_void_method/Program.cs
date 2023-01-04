// Создайте void метод для заполнения массива случайными числами и для вывода массива в консоль
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
int[] array = new int[10];
FillArray(array);
PrineArray(array);