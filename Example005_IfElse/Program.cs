// приглашение пользователя ко вводу, чтобы пользователь понимал, что хотят
Console.Write("Введите имя пользователя: ");

// тип данных строки, считываем данные при помощи команды Console.ReadLine
string username = Console.ReadLine();

if(username.ToLower() == "маша") // ToLower позволяет все символы строки перевести в нижний регистр
{
     Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
 