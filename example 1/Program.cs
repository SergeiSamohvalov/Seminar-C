namespace HelloWorld
{
class Program
{
static void Main(string[] args)
{
int a, b;

Console.WriteLine("Введите целое цисло а: ");

a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое цисло b: ");

b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
   Console.WriteLine($"а - наибольшее число "); 
}
else
{
  Console.WriteLine($"b - наибольшее число ");   
}
}
}
}