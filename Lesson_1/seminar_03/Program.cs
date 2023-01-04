//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число значение");
int num = Convert.ToInt32(Console.ReadLine());
int minNum = num * -1;

while (minNum <= num)
{
    Console.Write($"{minNum} ");
    minNum++;
}