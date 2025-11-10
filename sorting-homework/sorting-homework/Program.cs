using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            printArray(array1);
        }

        static void bubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i ++)
            {

            }
        }

        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
