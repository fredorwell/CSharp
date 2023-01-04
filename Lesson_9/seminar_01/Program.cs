/*
Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void NatNumbers(int num)
{
    if (num == 0) return;
    NatNumbers(num - 1);
    Console.Write($"{num} ");
}

Console.WriteLine("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());
NatNumbers(number);