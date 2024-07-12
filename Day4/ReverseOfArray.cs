using System;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize an array
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array:");
            PrintArray(arr);

            // Reverse the array
            ReverseArray(arr);

            Console.WriteLine("\nReversed array:");
            PrintArray(arr);

            Console.ReadLine();
        }

        // Function to reverse the array elements
        static void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                // Swap elements at start and end indices
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                // Move indices towards the center
                start++;
                end--;
            }
        }

        // Function to print array elements
        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
