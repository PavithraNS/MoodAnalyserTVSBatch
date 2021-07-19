
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModdAnalyserForTVSBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type type = typeof(string);
            //MethodInfo[] methods= type.GetMethods();
            //foreach(MethodInfo m in methods)
            //{
            //    Console.WriteLine(m.Name);
            //}
            //FetchCustomerDetailsUsingReflection();
            //MoodAnalyser m = new MoodAnalyser();
            //m.message = "";
            // CustomAttribute.AttributeDisplay(typeof(Employee));
            //CustomAttribute.AttributeDisplay(Type.GetType("Employee"));
            //Console.WriteLine(NumberOfTree.NumberOfTrees(10));
            NumberOfUniqueBSTs solution = new NumberOfUniqueBSTs();

            Console.WriteLine("Total number of BSTs possible for 3 distinct keys: " + solution.numTrees(5000));

            Console.WriteLine("\n\nTotal number of BSTs possible for 5 distinct keys: " + solution.numTrees(500));
            Console.ReadLine(); 
        }

        public static void FetchCustomerDetailsUsingReflection()
        {
            Type type=Type.GetType("ModdAnalyserForTVSBatch.Customer");
            Console.WriteLine("Name of the class "+type.Name);
            Console.WriteLine("FullName of the class " + type.FullName);
            Console.WriteLine("");
            PropertyInfo[] properties= type.GetProperties();
            Console.WriteLine("Displaying properties of customer class");
            foreach(PropertyInfo info in properties)
            {
                Console.WriteLine("datatype={0}\tproperty name={1}",info.PropertyType,info.Name);
            }
            Console.WriteLine("");
            ConstructorInfo[] constructors = type.GetConstructors();
            Console.WriteLine("Displaying constructors of customer class");
            foreach (ConstructorInfo info in constructors)
            {
                Console.WriteLine(info.ToString());
            }
            Console.WriteLine("");
            MethodInfo[] methods = type.GetMethods();
            Console.WriteLine("Displaying methods of customer class");
            foreach (MethodInfo info in methods)
            {
                Console.WriteLine("datatype={0}\tmethod name={1}", info.MemberType, info.Name);
            }
        }
    }
}
