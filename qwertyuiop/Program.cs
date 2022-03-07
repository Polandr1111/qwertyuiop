List<int> sad = new List<int>();
Random random=new Random();
for(int i = 0; i < 10; i++)
    sad.Add(random.Next());
while (true)
{
int X=int.Parse(Console.ReadLine());
    Console.WriteLine(sad[X]);

}
