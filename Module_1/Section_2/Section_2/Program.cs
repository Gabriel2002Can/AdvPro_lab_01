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

            var UserPassword = "secret";

            Console.WriteLine("Type your password to enter the system.\nPassword: ");

            var UserGuess = Console.ReadLine();

            if(UserGuess != UserPassword)
            {
                Console.WriteLine("\nThe password is wrong. Please try to log again.");
                return;
            }

            Console.WriteLine("\nYour User is authenticated.\n");

            Console.WriteLine("Do you want to change your password? (Y/*)");

            var UserChoice = Console.ReadLine();

            if (UserChoice == "Y")
            {
                Console.WriteLine("Type your new password:");

                UserPassword = Console.ReadLine();

                Console.WriteLine($"Password altered successfully to {UserPassword}");
            }

        }
    }
}
