const int pizza = 300;
const int pepsi = 130;
const int puff = 50;


Console.Write("Enter Number of Pizzas : ");
int uspi = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Number of Pepsis : ");
int uspp = Convert.ToInt32(Console.ReadLine());


Console.Write("Enter Number of Puffs : ");
int uspu = Convert.ToInt32(Console.ReadLine());

int total1 = pizza * uspi;
int total2 = pepsi * uspp; int total3 = puff * uspu;


Console.WriteLine("Total pizza Cost : " + total1);
Console.WriteLine("Total pepsi cost : " + total2);
Console.WriteLine("Total Puff Cost : " + total3);

int bill = total1 + total2 + total3;
Console.WriteLine("Total Bill in rupess : " + bill);

double gst1 = bill * 0.09;
double css = bill * 0.09;
double main = gst1 + css;
double tat = bill + main;


Console.WriteLine("Including GST : " + gst1);
Console.WriteLine("Including CSS : " + css);

Console.WriteLine("overall Bill : " + tat);




