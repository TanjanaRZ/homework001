Console.WriteLine("Введите число, соответствующие дню недели:");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1 || a == 2 || a == 3 || a == 4 || a == 5)
{
    Console.WriteLine("нет");
}
if (a == 6 || a == 7)
{
    Console.WriteLine("да");
}
if (a > 7 || a < 1)
{
    Console.WriteLine("Введённое число не соответствует дню недели.");
}
