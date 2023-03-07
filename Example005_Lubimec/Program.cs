Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "анна")
{
  Console.Write ("Добрый день госпожа Анна");
}
else
{
  Console.Write ($"Привет, {username}");
}