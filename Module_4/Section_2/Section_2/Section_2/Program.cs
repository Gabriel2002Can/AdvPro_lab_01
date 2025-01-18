using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = "1.5";
            var outDouble = 0.0;
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
            Console.WriteLine("Test type is {0}", outDouble.GetType());
            test = "Ronan";
            
            outDouble = 0.0;
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
            Console.WriteLine("Test value is {0}", outDouble);
        }
        private static bool parseDouble(string x, out double outDouble)

        {

            try
            {
                outDouble = Convert.ToDouble(x);


                return true;
            }
            catch (Exception)
            {
                outDouble = 0.0;
                return false;
                
            }
        }
    }
}
