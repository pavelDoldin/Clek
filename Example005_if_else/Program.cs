Console.Clear();
Console.WriteLine("Введите ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Леначка")
{
    Console.WriteLine("Ура, это же Леначка!");
}
else
{
    Console.Write("Привет: ");
    Console.WriteLine(username);
}