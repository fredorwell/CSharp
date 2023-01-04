/*
Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int num = new Random().Next(10,100);
Console.WriteLine($"Сгененрировали число {num}");
int first_num = num / 10;
int second_num = num % 10;
if (first_num > second_num)
{
    Console.WriteLine($"Наиболееьшее число {first_num}");
}
else if (second_num > first_num)
{
    Console.WriteLine($"Наиболееьшее число {second_num}");
}
else
{
    Console.WriteLine("Оба числа равны");
}