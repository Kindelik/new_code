
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "kindelik")
{
   Console.WriteLine ("Ура, это же Kindelik!!!");
}
else
{
  Console.Write("Hello, ");
  Console.WriteLine(username);
}