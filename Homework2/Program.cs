Console.Write("Введите  число: ");
string myString = Console.ReadLine().ToString();
int b = int.Parse(myString);
if (b / 100 > 0)
{
    Console.WriteLine(myString[2]);
}
else
{
    Console.WriteLine("Третьего цифры в числе нет!");
}