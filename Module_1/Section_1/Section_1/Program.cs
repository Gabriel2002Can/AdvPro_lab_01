using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Starting three question challenge
            Console.WriteLine("This is the company x question survey, please answer the following questions:\n");

            Console.WriteLine("1 - What is your name?");
            var NameCustomer = Console.ReadLine();

            Console.WriteLine("\n2 - How old are you?");
            var AgeCustomer = Console.ReadLine();

            Console.WriteLine("\n3 - What month were you born in?");
            var MonthCustomer = Console.ReadLine();

            Console.WriteLine("\n4 - Where are you from?");
            var PlaceCustomer = Console.ReadLine();

            Console.WriteLine("\n5 - What is your favorite movie?");
            var MovieCustomer = Console.ReadLine();

            Console.WriteLine($"\n{NameCustomer} was born in {PlaceCustomer}, {MonthCustomer} of {AgeCustomer}. Their favorite movie is {MovieCustomer}");
            
            //Avoiding the program to close after the input part is finished
            Console.ReadKey();
        }
    }
}
