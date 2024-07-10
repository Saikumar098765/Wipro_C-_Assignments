int i = Convert.ToInt32(Console.ReadLine());
int res = 0;
while (i >= 1)
{
    res = res + i % 10;
    i = i / 10;



}
//return res;
Console.WriteLine(res);