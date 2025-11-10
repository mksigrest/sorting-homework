/*
 * Maxwell Sigrest
 * Sorting Homework
 * Due 11/9/2025
 */

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sortingHomework
{
    internal class program
    {
        static void Main(string[] args)
        {
            //inital console lines
            Console.WriteLine("Hello, World");
            Console.WriteLine("Check out my awesome bubble sort!");

            //initialize arrays
            int[] array1 = new int[9] { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            int[] array2 = new int[9] { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

            //console line and call print array
            Console.WriteLine("The contents of the array 'array1':");
            printArray(array1);

            //call homemade bubblesort function
            bubbleSort(array1);

            //console line and call print array
            Console.WriteLine("Array 1 after the sort:");
            printArray(array1);

            //console line and call print array
            Console.WriteLine("The contents of the array 'array2':");
            printArray(array2);

            //call C# built in Sort function
            Array.Sort(array2);

            //console line and calls print array
            Console.WriteLine("Array 2 after the sort:");
            printArray(array2);
        }

        //homemade sort function
        static void bubbleSort(int[] array)
        {
            //sets array length to var, parses through array
            int n = array.Length;
            for (int i = 0; i < n; i ++)
            {
                //sorts through each array var one at a time
                for (int j = 0; j < n - i - 1; j ++)
                {
                    //if value is greater than next one, put it in temp val,
                    //move up, and change temp val to smaller one
                    if (array[j] > array[j + 1])
                    {
                        int k = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = k;
                    }
                }
            }
        }

        //print array function that makes code KISS
        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
