/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int AkerFunct(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numM != 0 && numN == 0) return AkerFunct(numM - 1, 1);
    else if (numM > 0 && numN > 0) return AkerFunct(numM - 1, AkerFunct(numM, numN - 1));
    return AkerFunct(numM, numN);
}

Console.Write("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = AkerFunct(numberM, numberN);

Console.WriteLine($"Функция Аккермана для чисел {numberM} и {numberN} = {result}");
// stack owerflow на 3-11 и 4-11 =(