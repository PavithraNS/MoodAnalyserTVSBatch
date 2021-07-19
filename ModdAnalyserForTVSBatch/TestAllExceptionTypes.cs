using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModdAnalyserForTVSBatch
{
    public class TestAllExceptionTypes
    {       
        public static void TestMethod(string message)
        {         
            try
            {
                int a = 10;
                //int c = a / 0;

                string[] array = { "hello", "welcome", "to" };
               // Console.WriteLine(array[4]);

                var numbers = new List<int>();
                var index = 0;
                 //Console.WriteLine("Removing item at index {0}", index);

                 //numbers.RemoveAt(index);

                if (string.IsNullOrEmpty(message))
                {
                    //throw new ArgumentNullException("Message can't be null or empty");
                }
              
                if (message.Length < 3)
                {
                    throw new InvalidOperationException("Message length should be greater or equal to 3 characters");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Parent exception of argument type
          
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
