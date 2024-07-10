Console.WriteLine("Enter Number : ");
int num = int.Parse(Console.ReadLine());
int rem, sum = 0;
int temp = num;

while (num > 0)
{
    rem = num % 10; 
    sum = sum+ (rem * rem * rem);
    num = num / 10;


}
if(temp == sum)
{
    Console.WriteLine("Armstrong");
}
    else
{
    Console.WriteLine("Not");
}