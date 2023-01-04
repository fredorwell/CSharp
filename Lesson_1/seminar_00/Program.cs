//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Console.Write("Введите число квадрат которого хотите получить: ");
int number = Convert.ToInt32(Console.ReadLine());
int sqr = number * number;
Console.Write($"Квадрат числа {number} - это {sqr}");
