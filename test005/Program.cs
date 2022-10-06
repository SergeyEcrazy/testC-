Console.WriteLine("Введите имя пользователя: ");
string username = (Console.ReadLine() ?? "0");

if(username.ToLower() == "даша")
{
    Console.WriteLine("Это моя ЛЮБИМКА");
}
else
{
    Console.Write("Hey, ");
    Console.WriteLine(username);
}