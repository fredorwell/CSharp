/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

void PalyndromCheck (int arg)
{
    if (arg > 99999)
    {
        Console.WriteLine($"Число {arg} не пятизначное");
    }
    else if((arg / 10000 == arg % 10) && ((arg % 100) / 10 == (arg / 1000) % 10))
    {
        Console.WriteLine($"Число {arg} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {arg} не является палиндромом");
    }

}


Console.WriteLine("Введите пятизначное число для проверки на палиндромность: ");
int num = Convert.ToInt32(Console.ReadLine());
PalyndromCheck(num);


