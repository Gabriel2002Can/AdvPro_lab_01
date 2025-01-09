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
            //Starting Section 2

            Console.WriteLine("Type your password to enter the system.\nPassword: ");

            var UserGuess = Console.ReadLine();

            if(UserGuess != "secret")
            {
                Console.WriteLine("\nThe password is wrong. Please try to log again.");
                return;
            }

            Console.WriteLine("\nYour User is authenticated.");
        }
    }
}
