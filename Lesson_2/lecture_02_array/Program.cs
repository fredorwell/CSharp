// Необходимо найти максимум в массиве из 9 чисел с помощью методов и без методов

int fMax(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//Индексы       0    1    2   3    4   5   6    7    8
int[] array = {15, 1211, 433, 54, 785, 46, 67, 238, 911};


int max = fMax(fMax(array[0], array[1], array[2]), fMax(array[3], array[4], array[5]), fMax(array[6], array[7], array[8]));

Console.Write($"max = {max}");
