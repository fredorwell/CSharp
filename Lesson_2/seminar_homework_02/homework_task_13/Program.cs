/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void ThirdDig(int arg)
{
    int result = 0;
    if (arg < 100)
    {
    Console.Write($"Число {arg} не трехзначное и третьей цифры нет");
    }
    else if (arg >= 1000)
    {
        result = arg;
        while (result >= 1000)
        {
            result = result / 10;
        }
        result = result % 10;
        Console.Write($"Третья цифра числа {arg} - это {result}");    
    }
    else
    {
    result = arg % 10;
    Console.Write($"Третья цифра числа {arg} - это {result}");
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdDig(num);
