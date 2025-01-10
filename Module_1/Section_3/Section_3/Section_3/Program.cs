using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Section_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (var count = 0; count < 5; count ++)
            {

                //Restarting after each loop 
                var i = 1;
                var operation = +1;
                

                while (i > 0)
                {
                    Console.WriteLine(i);
                    if (i == 10)
                    {

                        Console.WriteLine(i);

                        //Inverting operation
                        operation = -1;
                    }
                    i += operation;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
