﻿/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число для проверки четности:");
int num = Convert.ToInt32(Console.ReadLine());

if (num %2 == 0)
{
    Console.Write("Да, число четное");
} 
else
{
    Console.Write("Нет, число не четное");
}