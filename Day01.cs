/*int employeeid;
string name;
double salary;
bool isContractEmp;
int dept;
string emailId;
*/

Console.WriteLine("Enter Employee ID : ");
int  employeId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your Employee ID is : "+employeId);

Console.WriteLine("Enter Your Name : ");
string name = Console.ReadLine();
Console.WriteLine("Your Name is : " + name);

Console.WriteLine("Enter Your Salary : ");
double salary = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Salary is : " + salary);

Console.WriteLine("Enter Department Number");
int dept = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your Department Number is : " + dept);

Console.WriteLine("Enter Your Email Id : ");
string emailId = Console.ReadLine();
Console.WriteLine("Your Email is : "+emailId);

double HRA = salary * 0.15;
Console.WriteLine("House Rent is : " + HRA);

double MA = salary * 0.10;
Console.WriteLine("Medical Allowance is : " + MA);

double TA = salary * 0.15;
Console.WriteLine("Travel Allowance is : " + TA);

double netSalary = salary + HRA + MA + TA;
Console.WriteLine("Total Net Salary is "+netSalary);


