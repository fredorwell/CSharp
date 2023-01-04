/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void WeekendChecker(int arg)
{
    if (arg < 1 || arg > 7)
    {
        Console.Write($"Дня недели под номером {arg} не существует");
    }
    else if (arg < 6)
    {
        switch (arg)
        {
            case 1:
                Console.WriteLine($"{arg} - это понедельник и это не выходной день");
                break;
            case 2:
                Console.WriteLine($"{arg} - это Вторник и это не выходной день");
                break;
            case 3:
                Console.WriteLine($"{arg} - это Среда и это не выходной день, Но среда - это маленькая пятница");
                break;
            case 4:
                Console.WriteLine($"{arg} - это Четверг и это не выходной день, но до него осталось совсем чуть-чуть");
                break;
            case 5:
                Console.WriteLine($"{arg} - это Пятница и это не выходной день, но вот завтра уже выходной");
                break;
            default:
                Console.WriteLine("Произошла проблема =(");
                break;
        }
    }
    else
    {
        switch (arg)
        {
            case 6:
                Console.WriteLine($"{arg} - это Суббота и это выходной день!");
                break;
            case 7:
                Console.WriteLine($"{arg} - это Воскресенье и это не выходной день, но завтра на работу");
                break;
            default:
                Console.WriteLine("Произошла проблема =(");
                break;
        }
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
WeekendChecker(num);
