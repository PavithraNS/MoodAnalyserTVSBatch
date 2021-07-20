using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemoTVSBatch
{
    //Generic Class
   public class GenericClass<T>
    {
        //public T[] array;

        //public GenericClass(T[] array)
        //{
        //    this.array = array;
        //}

        public T[] ToPrint(T[] array)
        {
            Console.WriteLine("\nIterating over each element of Array\n");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            return array;
        }
        //public void ToPrint()
        //{
        //    Console.WriteLine("\nIterating over each element of Array\n");
        //    foreach (var element in array)
        //    {
        //        Console.Write(element + " ");
        //    }
        //}
    }
}
