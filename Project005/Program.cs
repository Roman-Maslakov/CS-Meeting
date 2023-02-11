Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("АРИКУ! Это же Маша!");
}
else
{
    Console.Write("Привет,");
    Console.Write(username);
}