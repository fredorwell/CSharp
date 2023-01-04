Console.WriteLine("Введите имя пользователя:");
string user_name = Console.ReadLine();

if (user_name.ToLower() == "коля")
{
    Console.WriteLine("Как же я тебя долго ждал! Ты такой замечательный человек!");
}
else
{
    Console.Write("Здравствуй, ");
    Console.Write(user_name);
}