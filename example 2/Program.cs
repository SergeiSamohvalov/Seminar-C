namespace HelloWorld
{
class Program
{static void Main(string[] args)
{
int a, b, c;

Console.WriteLine("Введите целое цисло а: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое цисло b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое цисло c: ");
c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
       Console.WriteLine($"а - наибольшее число ");  
    }
    else
   if (b > c)
{
  Console.WriteLine($"b - наибольшее число ");  
}
}
else
{
    Console.WriteLine($"c - наибольшее число ");
}
}
}}
