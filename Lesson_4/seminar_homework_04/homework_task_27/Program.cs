/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int SumOfDig(int arg)
{
    int result = 0;
    while (arg != 0)
    {
        result = result + (arg % 10);
        arg = arg / 10;        
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма всех цифр в числе {num}: {SumOfDig(num)} ");