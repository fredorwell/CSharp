/*
Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно

*/

int multipleCheck(int number1, int number2)
{
    int checkDiv = number1 % number2;
    return checkDiv;
}


Console.Write("Введите первое число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int numB = Convert.ToInt32(Console.ReadLine());
int check = multipleCheck(numA, numB);
if (check == 0)
{
    Console.Write($"Число {numA} кратно {numB}");
}
else
{
    Console.Write($"Число {numA} не кратно {numB}");   
}

