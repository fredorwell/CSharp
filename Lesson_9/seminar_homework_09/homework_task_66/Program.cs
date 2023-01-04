/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SummNatDig (int numMin, int numMax, int result)
{
    result = result + (numMin++);
    //Console.WriteLine($"m - {numMin}, n - {numMax}, sum - {result}"); // строка для дебага
    if (numMin > numMax) return result; 
    else return SummNatDig(numMin, numMax, result);
}

Console.Write("Введите значение M: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = SummNatDig(numberA, numberB, 0);
Console.WriteLine($"Сумма элементов: {result}");
