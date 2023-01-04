/*
Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

bool CheckTriangle(int a, int b, int c)
{
    if ((a + b > c) && (a + c > b) && (b + c > a)) return true;
    else return false;
}

Console.WriteLine("Введите три числа ");
Console.Write("Введите первую длинну: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую длинну: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью длинну: ");
int a3 = Convert.ToInt32(Console.ReadLine());
bool resultCheck = CheckTriangle(a1, a2, a3);
if (resultCheck) Console.Write("Такой треугольник возможен");
else Console.Write("Такой треугольник не возможен");
