Console.Write("Введите  число: ");
string myString = Console.ReadLine().ToString();
int b = int.Parse(myString);
if (b < 0)
{
    b = -1 * b;
    if (b / 100 > 0)
{
    string s = b.ToString();
    Console.WriteLine(s[2]);
}
else
{
    Console.WriteLine("Третьего цифры в числе нет!");
}
}
else
{
    if (b / 100 > 0)
{
    Console.WriteLine(myString[2]);
}
else
{
    Console.WriteLine("Третьего цифры в числе нет!");
}
}