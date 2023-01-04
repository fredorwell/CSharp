/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double Power(int arg, int pow)
{
    int i = 1;
    int result = arg;
    while (i != pow)
    {
        i++;
        result = result * arg;   
    }
    return result;
}

Console.Write("Введите число которое будем возводить в степень: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень мы будем возводить это число: ");
int pow = Convert.ToInt32(Console.ReadLine());

double result1 = Power(num,pow);
Console.WriteLine($"Результат через рукописный метод: {result1}");

// Прим: Я не очень понял почему это надо сделать через цикл, а не через стандартный метод Math.Pow, но хозяин-барин :)
double result2 = Math.Pow(num,pow);
Console.WriteLine($"Результат через стандартный метод: {result2}");