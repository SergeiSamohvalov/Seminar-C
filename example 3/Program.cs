namespace HelloWorld
{
class Program
{
static void Main(string[] args)
{
int a;

Console.WriteLine("Введите целое цисло: ");

a = Convert.ToInt32(Console.ReadLine());
if (a%2 == 0)
{
    Console.WriteLine("Это число - четное");
}  
else 
{
    Console.WriteLine("Это число - нечетное");
}
}
}
}


