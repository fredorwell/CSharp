/*
Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

*/

double Gipotinuse(double xa, double ya, double xb, double yb)
{
    double result = Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2));
    result = Math.Round(result,2, MidpointRounding.ToZero);
    return result;
}

Console.Write("Первая точка - введите координату x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка - введите координату y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка - введите координату x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка - введите координату y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Gipotinuse(x1, y1, x2, y2);
Console.Write($"Расстояние между точками {x1},{y1} и {x2},{y2} - {distance}");



