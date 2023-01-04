/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
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

int[] ReadNum(int count)
{
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите Число номер {i + 1} - ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}
int CountPositive(int[] array)
{
    int result = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}

Console.Write("Введите сколько чисел вы хотите ввести: ");
int countNum = Convert.ToInt32(Console.ReadLine());
int[] arr = ReadNum(countNum);
PrintArray(arr);
Console.Write($"Количество положительных чисел: {CountPositive(arr)}");