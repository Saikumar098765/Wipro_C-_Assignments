namespace sai

{class program{
        public static void Main(string[] args)
        {
            ///int a = avg();
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is " + age);
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Your Name is " + name);

        }
        public static avg()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int sum = i + j + k;
            Console.WriteLine(sum);

        }
    }
}