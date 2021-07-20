using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemoTVSBatch
{
    public class MaximuxGenericClass<T> where T: IComparable
    {
        public T first, second, third;

        public MaximuxGenericClass(T first, T second, T th)
        {
            this.first = first;
            this.second = second;
            third = th;
        }
        public static T FindMaxValueOfInt(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("All the are having same number");
                return default;
            }
        }

        public T TestMax()
        {
            T max=FindMaxValueOfInt(first,second,third);
            return max;
        }
    }
}
