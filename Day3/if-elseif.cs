namespace DepartmentNames
{
    internal class Department
    {
       public static void Main(String[] args)
        {
            const int SalesDept = 10;
            const int CourseDept = 20;
            const int SaleDept = 30;

            Console.Write("Enter Your Dept : ");
            int dep = Convert.ToInt32(Console.ReadLine());

            if(dep == SalesDept ) 
            {
                Console.WriteLine("Your SalesDept");

            }
            else if(dep == CourseDept )
            {
                Console.WriteLine("Your Course dept");
            }
            else if(dep == SaleDept )
            {
                Console.WriteLine("Your Sale dept");
            }
            else
            {
                Console.WriteLine("Wrong Dept");
                Console.WriteLine("Enter Correct Dept");
            }
            
        }
    }
}
