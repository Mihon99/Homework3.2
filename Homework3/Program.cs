Console.Write("Введите  число: ");
int b = int.Parse(Console.ReadLine());
if(b<1)
{
    Console.WriteLine("Ошибка");
}
else if(b > 7)
{
    Console.WriteLine("Ошибка");
}
else if(b == 6)
{
    Console.WriteLine("Ура, выходные начались, чилим!");
}
else if(b == 7)
{
    Console.WriteLine("Последний день выходных, отдохни как следует!");
}
else if(b >= 1 && b <= 5)
{
    Console.WriteLine("Будние дни, пашем как папа Карло!");
}
