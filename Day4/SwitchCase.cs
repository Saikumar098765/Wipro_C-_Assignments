const int SalesDept = 10;
const int HrDept = 20;
const int RrDept = 30;

Console.WriteLine("Enter Dept Number : ");

int dp = int.Parse(Console.ReadLine());

switch (dp)
    {
        case SalesDept :
        Console.WriteLine("SalesDept");
        break;

        case HrDept :
        Console.WriteLine("HrDept");
        break;

        case RrDept :
        Console.WriteLine("RrDept");
        break;

        default:
        Console.WriteLine("NoDept");
        break;
        
    }
