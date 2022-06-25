namespace HelloWorld
{class Program
{
static void Main(string[] args)
{
int N;
int i;
Console.WriteLine("Введите ЛЮБОЕ целое цисло: ");
N = Convert.ToInt32(Console.ReadLine());
for (i=0; i<N; i++)
{
   if(i%2 == 0)
  {
    Console.Write(i + " ");
  }
    }
    
}
}
}


