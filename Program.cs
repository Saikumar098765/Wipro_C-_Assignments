namespace forloop
{
    class program
    {
        public static void Main(String[] args)
        {
            //Print First 10Numbers
            for (int j = 1; j <= 10; j++) 
                {
                    Console.Write(" "+j);
                }
            
            Console.WriteLine("\n---------");

            //Print Odd Numbers from 1 to 50
            for(int j1 = 1; j1 <= 50; j1++)
            {
                j1 = j1 + 2;
                j1++;
                Console.Write(" " + j1);
            }
        }
    }
}