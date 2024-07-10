const int ricePrice = 1000;

Console.WriteLine("Welcome to General Store ");

Console.Write("Enter Product ID : ");
int prdId = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Product Name : ");
string prdName = Console.ReadLine();

Console.WriteLine("Unit Price of Rice  : "+ricePrice);

Console.WriteLine("Enter Quantity : ");
int quality = Convert.ToInt32(Console.ReadLine()); 

decimal totalbill = (decimal)ricePrice * quality;
Console.WriteLine("Total Amount : "+totalbill);

decimal discount = 0;
//Console.WriteLine("Dicount is : ");
if(totalbill > 1000)
{
    discount = 0.10m;
}
if (totalbill > 3000)
{
    discount = 0.15m;
}
if (totalbill > 5000)
{
    discount = 0.20m;
}

decimal totalamount = totalbill * discount;
Console.WriteLine("After Discount Grant Total Amount : "+totalamount);

