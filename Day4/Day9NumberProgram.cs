using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter hours: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Enter minutes: ");
        int minutes = int.Parse(Console.ReadLine());

       
        Console.WriteLine(NumberHours(hours, minutes));
    }

    static string NumberHours(int hours, int minutes)
    {
        string[] numbers = {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen",
            "nineteen", "twenty", "twenty one", 
        };

        string timeInWords = "";

        if (minutes == 0)
        {
            timeInWords = $"{numbers[hours]} o' clock";
        }
        else if (minutes == 1)
        {
            timeInWords = $"one minute past {numbers[hours]}";
        }
        else if (minutes == 15)
        {
            timeInWords = $"quarter past {numbers[hours]}";
        }
        else if (minutes == 30)
        {
            timeInWords = $"half past {numbers[hours]}";
        }
        else if (minutes == 45)
        {
            timeInWords = $"quarter to {numbers[(hours % 12) + 1]}";
        }
        else if (minutes < 30)
        {
            timeInWords = $"{numbers[minutes]} minutes past {numbers[hours]}";
        }
        else
        {
            timeInWords = $"{numbers[60 - minutes]} minutes to {numbers[(hours % 12) + 1]}";
        }

        return timeInWords;
    }
}
