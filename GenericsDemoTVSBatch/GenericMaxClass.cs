using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemoTVSBatch
{
    public class GenericMaxClass<T> where T : IComparable
    {
        /// We will accept an array of values 
        /// and with the help of the parameterised constructor
        /// it is initialised
        public T[] values;
        public GenericMaxClass(T[] values)
        {
            this.values = values;
        }
        /// Sorting the array of the values
        /// and returning it
        public static T[] SortedValues(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        /// Implementing a generic method to
        /// check for any data type
        /// and give the maximum out of them
        /// by returning the first value out of the sorted array
        public static T TestMax(T[] values)
        {
            var sorted = SortedValues(values);
            return sorted[values.Length-1];
        }
        /// Defining the TestMaximum method
        /// to internally call the static TestMaximum method
        public T TestMaximum()
        {
            T max = GenericMaxClass<T>.TestMax(this.values);
            return max;
        }
        /// Defining a method to print the maximum value
        /// by invoking the TestMaximum method
        public void PrintMax()
        {
            Console.WriteLine("Maximum value is " + TestMaximum());
        }
    }
}
