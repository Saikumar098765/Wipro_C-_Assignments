﻿/*
1) 1  4  9  16   25  36  49  64  81 100
Square of its Own Number
*/
for (int i=1; i<=10; i++)
{
    Console.Write(" "+i * i);
}

Console.WriteLine("\n---------------------");

/*
 * 0   1    1   2   3  5  8  13  21  34  55 89 144
 * Fibnnoci Series
 */
int n1 = 0, n2 = 1, n3;
Console.Write(n1 + " " + n2 + " ");
for (int i = 2; i < 13; i++)
{
    n3 = n1 + n2;
    Console.Write(n3 + " ");
    n1 = n2;
    n2 = n3;
}

Console.WriteLine("\n---------------");

/*
 * 3 5 6 9 10 12 15 18 20 21 24 25 27 30
 */
for (int i = 3; i <= 30; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        Console.Write(i + " ");
    }
}