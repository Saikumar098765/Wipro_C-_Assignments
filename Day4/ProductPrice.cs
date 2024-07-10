
const int product = 5;
decimal amount = 0;
for (int i = 0; i < product; i++)
{
    Console.Write($"Enter Products Price {i+1} : ");
    decimal cost = decimal.Parse(Console.ReadLine());
    
    Console.Write($"Enter Quality {i+1} : ");
    int weight = int.Parse(Console.ReadLine());

    amount += cost * weight;


}
Console.WriteLine("Total : " + amount);