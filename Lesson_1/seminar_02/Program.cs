Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("среда");
        break;
    case 4:
        Console.WriteLine("четверг");
        break;
    case 5:
        Console.WriteLine("пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Вы ввели не корректное значение :(");
        break;
}
/*
if (num > 7 || num < 1)
{
    Console.Write("Вы ввели не корректное значение :( ");
}
if (num == 1)
{
    Console.Write("Это понедельник");
}
if (num == 2)
{
    Console.Write("Это Вторник");
}
if (num == 3)
{
    Console.Write("Это среда");
}
if (num == 4)
{
    Console.Write("Это четверг");
}
if (num == 5)
{
    Console.Write("Это пятница. Придется пить :)");
}
if (num == 6)
{
    Console.Write("Это Суббота");
}
if (num == 7)
{
    Console.Write("Это Воскресенье. Завтра на работу :(");
}*/