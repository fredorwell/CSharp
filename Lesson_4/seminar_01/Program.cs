/*
Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

void CountDig(int arg)
{
    int count = 0;
    int result = arg;
    while (result != 0)
    {
        result = result / 10;
        count++;
    }
    Console.WriteLine($"Количество цифр в числе {arg} равно: {count} ");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
CountDig(num);