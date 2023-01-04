// Нарисовать в консоли треугольник серпинского с помощью комманд SetCursorPosition и WriteLine

Console.Clear();

int xa = 20; // Координата х первой точки
int ya = 10; // Координата y первой точки

int xb = 5; // Координата х второй точки
int yb = 30; // Координата y второй точки

int xс = 80; // Координата х третьей точки
int yс = 30; // Координата y третьей точки
Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");
Console.SetCursorPosition(xс, yс);
Console.WriteLine("*");


int x = xa;
int y = ya; 
int count = 0;

while (count < 5000)
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x + xс) / 2;
        y = (y + yс) / 2;
    }
    Console.SetCursorPosition(x,y);
    // System.Threading.Thread.Sleep(10); // Добавил задержку для зрелищности
    Console.WriteLine("+");
    count++;
}

