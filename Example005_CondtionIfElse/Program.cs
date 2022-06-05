Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
// ToLower операция позволяет перевести все символы в нижний регистр
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}