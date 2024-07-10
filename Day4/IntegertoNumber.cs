class program
{
    static void Main(string[] args)
    {
        int num = 754;
        string output = NumToWords(num);
        Console.Write("Enter Number :"+output);
        // Output: one two three
    }
    static string NumToWords(int num)
    {
        string[] digitToWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string numStr = num.ToString();
        string result = " ";

        foreach (char digit in numStr)
        {
            int index = digit - '0';
            // Convert char digit to int index
            if (index >= 0 && index <= 9)
            {
                result += digitToWord[index] + " ";
            }
        }
        return result.Trim();
    }
}