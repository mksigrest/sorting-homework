using System;

namespace sortingHomework
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            Console.WriteLine("Check out my awesome bubble sort!");

            int[] array1 = new int[9] { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            int[] array2 = new int[9] { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

            Console.WriteLine("The contents of the array 'array1'");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
        }

        static void bubbleSort(int[] array)
        {
            int n = array.Length;

        }

        static void printArray(int[] array)
        {

        }
    }
}
