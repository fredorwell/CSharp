/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int HandPow(int num, int power)
{
    int result = num;
    if (power == 0 ) return 1;
    else if (power != 1) result = num * HandPow(num, power -1 );
    return result ;
}



Console.Write("Введите значение 1: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 2: ");
int sqr = Convert.ToInt32(Console.ReadLine());

int resSqr = HandPow(number, sqr);
Console.WriteLine($"Число {number} в степени {sqr}: {resSqr}");

