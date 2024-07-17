using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        LinkedList<string> list = new LinkedList<string>();

        
        list.AddLast("Sai");
        list.AddLast("Kumar");
        list.AddLast("Uruvakili");

        Console.WriteLine("List is :");
        foreach (var value in list)
        {
            Console.WriteLine(value);
        }

        ListValue(list, "Kumar");
        Console.WriteLine("After It Remove : ");
        foreach (var value in list)
        {
            Console.WriteLine(value);
        }
    }

    
    static void ListValue(LinkedList<string> list, string value)
    {
        
        LinkedListNode<string> word = list.Find(value);

        if (word != null)
        {
            list.Remove(word);
            Console.WriteLine($"In the Above List this '{value}' removed.");
        }
        else
        {
            Console.WriteLine($"List value '{value}' not found.");
        }
    }
}
