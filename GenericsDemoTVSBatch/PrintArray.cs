using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemoTVSBatch
{
    //Without Generics
    class PrintArray
    {
        //Integer Array
        public static void ToPrint(int[] intArray)
        {
            Console.WriteLine("Iterating over each element of interger Array");
            foreach (int element in intArray)
            {
                Console.Write(element+" ");
            }
            Console.WriteLine("\n-----------------------------");
        }
        //Display each element of double array
        public static void ToPrint(double[] doubleArray)
        {
            Console.WriteLine("Iterating over each element of double Array");
            foreach (double element in doubleArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n-----------------------------");
        }
        public static void ToPrint(char[] charArray)
        {
            Console.WriteLine("Iterating over each element of char Array");
            foreach (char element in charArray)
            {
                Console.Write(element + " ");
            }
        }

        public static void ToPrint<T>(T[] array)
        {
            Console.WriteLine("\nIterating over each element of Array\n");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
