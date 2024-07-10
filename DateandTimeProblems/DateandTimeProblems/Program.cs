namespace datetime
{
    internal class program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            
            //Todays Date
            dt= DateTime.Now;
            Console.WriteLine("Todays Date and Time : "+dt);
            Console.WriteLine(dt.ToString("dddd-MMM-yyyy"));
            
            //Adding 10 days to Present Date
            DateTime adddays = dt.AddDays(10);
            Console.WriteLine("Adding 10Days Of Todays Date : "+adddays);
            Console.WriteLine(adddays.ToString("ddd-MM-yyyy"));
            
            //Difference Between two dates

            TimeSpan timeSpan = DateTime.Now - adddays;
            int gapdays = timeSpan.Days;
           

            Console.WriteLine("Gap between 2 Dates : "+gapdays);
            
            DateTime ti = new DateTime();
            ti = DateTime.Now;
            Console.WriteLine(ti.ToString("ddd-dd-MMM-yyy"));
        }
    }
}