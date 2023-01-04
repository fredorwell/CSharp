/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
void SecondDig(int arg)
{
    int result = arg;

    if (result >= 1000)
    {
        while (result >= 1000)
        {
            result = result / 10;
        }
        result = (result % 100) / 10;
        Console.Write($"{arg} не трехзначное число, но вторая цифра - это {result}");
    }
    else if (result >= 100)
    {
        result = (arg % 100) / 10;
        Console.Write($"Вторая цифра числа {arg} - это {result}");
    }
    else if (result >= 10)
    {
        result = (arg % 10);
        Console.Write($"Вторая цифра числа {arg} - это {result}");
    }
    else
    {
        Console.Write($"У числа {arg} нет второй цифры");
    }
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
SecondDig(num);