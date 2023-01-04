/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void TableCube(int arg)
{
    int i = 1;
    if (arg > 0)
    {
        while (i <= arg)
        {
            Console.WriteLine($"{i,3} {Math.Pow((i), 3),3}");
            i++;
        }
    }
    else
    {
        Console.WriteLine("Вы ввели отрицательное значение");
    }
}


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
TableCube(num);