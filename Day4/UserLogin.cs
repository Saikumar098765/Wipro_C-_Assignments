Console.Write("Enter Your UserID : ");
string userid = Console.ReadLine();
userid = userid.ToLower();
userid = userid.Trim();

Console.Write("Enter Your Password : ");
string password = Console.ReadLine();

if(userid == "admin" && password == "admin123")
{
    Console.WriteLine("Welcome to Home");

}
else
{
    Console.WriteLine("Get Out this Home");
}