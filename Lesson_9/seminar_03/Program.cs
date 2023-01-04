/*
Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
4 5 3 -> 12
45 -> 9
*/

int SumOfDig(int num) //453  //45 // 4
{
    int result = num % 10; /// 3
    if (num != 0) result += SumOfDig(num / 10);
    return result ;
}


Console.WriteLine("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumOfDig(number);
Console.WriteLine($"Сумма цифр: {sum}");