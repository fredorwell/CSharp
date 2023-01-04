/*
Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

void NatNumbersMinMax(int min, int max)
{
    if (min > max) return;
    NatNumbersMinMax(min, max - 1);
    Console.Write($"{max} ");
}

void NatNumbersMaxMin(int Min, int Max)
{
    if (Min > Max) return;
    Console.Write($"{Max} ");
    NatNumbersMaxMin(Min, Max - 1);

}
Console.WriteLine("Введите первое значение: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB) NatNumbersMinMax(numberA, numberB);
else if (numberA > numberB) NatNumbersMaxMin(numberB, numberA);
else Console.WriteLine("В вашем диапозоне нет числе в промежутке :( ");
