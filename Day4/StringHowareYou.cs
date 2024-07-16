using System;

public class Program
{
    public static void Main()
    {
        string s1 = "Hi How are you";
        string s2 = "You are best thing";
        string s3 = "Practice makes man perfect";

        Console.WriteLine($"Input: {s1} \nOutput: {WordsCount(s1)}");
        Console.WriteLine($"Input: {s2} \nOutput: {WordsCount(s2)}");
        Console.WriteLine($"Input: {s3} \nOutput: {WordsCount(s3)}");
    }

    public static int WordsCount(string input)
    {
        int i = 0;
        string[] words = input.Split(' ');

        foreach (string a in words)
        {
            if (a.Length == 3)
            {
                i++;
            }
        }

        return i;
    }
}
