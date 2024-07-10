namespace UdemyCourse
{
    public class UdemyCourseEntries
    {
        public static void Main(String[] args)
        {
            DateTime courseOn = new DateTime(2024, 6, 25);
            DateTime lastDate = new DateTime(2024, 6, 20);

            const int COURSE_FEE = 25000;

            Console.WriteLine("Udemy registration form ");
            

            Console.Write("Enter Name :");
            string name = Console.ReadLine();

            Console.Write("Enter Phone number :");
            int phnNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Email ID :");
            string emailId = Console.ReadLine();

            Console.Write("Applying date (dd-mm-yyy):");
            DateTime date = DateTime.Parse(Console.ReadLine());


            Console.Write("Already Subscribed (True/False)");
            bool isSubscribed = bool.Parse(Console.ReadLine());

            double remainingDate = (courseOn - date).TotalDays;

            if (isSubscribed && remainingDate < 5)
            {
                Console.WriteLine("Need to Pay 15% late fee :" + (COURSE_FEE * 0.15));
                Console.WriteLine("Total fee to pay : " + (COURSE_FEE + (COURSE_FEE * 0.15)));
            }
            else if (remainingDate < 5 && remainingDate <= 10)
            {
                Console.WriteLine((COURSE_FEE * 0.1) + " Will be provided");
            }
            else if (remainingDate > 10)
            {
                Console.WriteLine((COURSE_FEE * 0.15) + " Will be provided");
            }



        }
    }
}