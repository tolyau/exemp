Console.Write("Введи имя: ");
string userN = Console.ReadLine();

if(
    userN.ToLower() == "masha"
    )
{
    Console.WriteLine("Ура Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userN);
}