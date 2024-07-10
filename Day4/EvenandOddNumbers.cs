


int[] numbers = new int[5];
int sumEven = 0;
int sumOdd = 0;

Console.WriteLine("Enter 20 numbers:");


for (int i = 0; i < 5; i++)
{
    Console.Write($"Number {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}


for (int i = 0; i < 5; i++)
{
    if (numbers[i] % 2 == 0)
    {
        sumEven += numbers[i];
    }
    else
    {
        sumOdd += numbers[i];
    }
}

Console.WriteLine("Sum of even numbers:" +sumEven);
Console.WriteLine("Sum of odd numbers:" +sumOdd);
