Console.WriteLine("Введите число ");
string? n = (Console.ReadLine());
if(n.Length-1<2)
{
    Console.WriteLine("Третьей цифры в заданном числе нет.");
}
else
{
  Console.WriteLine($"{n[2]}");
}




