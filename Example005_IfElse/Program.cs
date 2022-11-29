Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "igor")
{
    Console.WriteLine("Hello, Igor!");
}
else
{
    Console.Write("Hy, ");
    Console.WriteLine(username);
}