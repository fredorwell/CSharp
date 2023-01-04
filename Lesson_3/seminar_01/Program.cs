/*
Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
*/



void Quarter(int arg)
{

    switch (arg)
    {
        case 1:
            Console.WriteLine("В первой четверти участвуют точки с координатами X больше нуля и Y больше 0");
            break;
        case 2:
            Console.WriteLine("В во второй четверти участвуют точки с координатами X больше нуля и Y меньше 0");
            break;
        case 3:
            Console.WriteLine("В во второй четверти участвуют точки с координатами X меньше и Y меньше 0");
            break;
        case 4:
            Console.WriteLine("В во второй четверти участвуют точки с координатами X больше 0 и Y меньше 0");
            break;
        default:
            Console.WriteLine("Вы ввели не корректное значение");
            break;
    }
}

Console.Write("Введите номер четверти координаты которых вы хотите получить: ");
int num_quart = Convert.ToInt32(Console.ReadLine());
Quarter(num_quart);