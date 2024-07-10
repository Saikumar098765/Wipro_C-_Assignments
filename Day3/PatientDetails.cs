Console.WriteLine("Patience Details  ");

Console.Write("Enter Patience Name : ");
string name = Console.ReadLine();

Console.Write("Enter Patience ID : ");
int patId = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Patient Weight (Grams ): ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter patient Mobile Number :  ");
int moNu = Convert.ToInt32(Console.ReadLine());

Console.Write("does patient has insurence : ");
bool insu = Convert.ToBoolean(Console.ReadLine());

//Console.WriteLine("Enter patient Joining Date : ");
DateTime dt = new DateTime();
dt = DateTime.Now;

Console.WriteLine("Patient Details are Below ");

Console.WriteLine("Patient Name is : "+ name);
Console.WriteLine("patient ID is : "+patId);
Console.WriteLine("patience Weight : "+weight);
Console.WriteLine("Patient Mobile Number : " + moNu);
Console.WriteLine("Joining Date Of Patient : "+dt.ToString("yyyy-MMM-dd"));

