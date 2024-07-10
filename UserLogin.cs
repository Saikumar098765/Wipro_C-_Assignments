Console.Write("Enter Your UserID : ");
string userid = Console.ReadLine();
userid = userid.ToLower();

Console.Write("Enter Your Password : ");
string password = Console.ReadLine();

if(userid.Trim() == "admin" && password.Trim() == "admin123")
{
    Console.WriteLine("Welcome to Home");

}
else
{
    Console.WriteLine("Get Out this Home");
}