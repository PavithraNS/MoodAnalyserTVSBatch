using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsDemoTVSBatch;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] {25,12,78,34,56};
            double[] doubleArray = new double[] { 12.23, 12.34,23.56 };
            char[] charArray = new char[] { 'H','E','L','L','O' };
            //PrintArray.ToPrint(intArray);
            //PrintArray.ToPrint(doubleArray);
            //PrintArray.ToPrint(charArray);
            //PrintArray.ToPrint<int>(intArray);
            //PrintArray.ToPrint<double>(doubleArray);
            //PrintArray.ToPrint<char>(charArray);

            //GenericClass<int> genericClass = new GenericClass<int>(intArray);
            //genericClass.ToPrint();

            //new GenericClass<int>(intArray).ToPrint();
            //new GenericClass<double>(doubleArray).ToPrint();
            //new GenericClass<char>(charArray).ToPrint();

            //GenericClass<int>.ToPrint(intArray);
            //GenericClass<double>.ToPrint(doubleArray);
            //GenericClass<char>.ToPrint(charArray);
            //new GenericMaxClass<int>(intArray).PrintMax();
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddFirst(30);
           
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

        }
    }
}
