/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (num == 1)
{
    Console.WriteLine($"Четных чисел в диапазоне от 1 до {num} нет");
}
else
{
while (i <= num)
{
    Console.Write($"{i} ");
    i = i + 2;
}
}