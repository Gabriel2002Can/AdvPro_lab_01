using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_1
{
    internal class Program
    {
        public class MyCustomException : FormatException
        {
            public MyCustomException(string errorMessage) : base(errorMessage) { }
        }

        static void Main(string[] args)
        {
            //The same method from one of the previous sections
            bool IsDigitsOnly(string str)
            {
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }

            int studentNumber = 0;

            //Continue until break
            while (true)
            {
                Console.WriteLine("How many students are you going to register?");
                string input = Console.ReadLine();

                try
                {
                    studentNumber = int.Parse(input);

                    if (studentNumber <= 0)
                    {
                        throw new MyCustomException("The number of students must be greater than zero.");
                    }

                    break;
            }

                //Considering that my custom error is a derivation of the FormatException, it needs to go first
                catch (MyCustomException e)
                {
                Console.WriteLine($"{e.Message}");
            }
                catch (FormatException)
                {
                Console.WriteLine("The input should be a valid number.");
            }

            }

            var Students = new string[studentNumber, 2];

            Console.WriteLine("\n");

            for (int s = 0; s < studentNumber; s++)
            {
              
                while (true)
                {
                    Console.WriteLine("Input the Student's name:");
                    string name = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        Students[s, 0] = name;
                        break; 
                    }

                    Console.WriteLine("Name cannot be empty or whitespace.");
                }

                while (true)
                {
                    Console.WriteLine($"Input {Students[s, 0]}'s grade:");

                    string grade = Console.ReadLine();

                        try
                        {
                            if (!IsDigitsOnly(grade))
                        {
                            throw new MyCustomException("The grade must be a numeric value.");
                        }

                        Students[s, 1] = grade;
                        break;
                    }
                        catch (MyCustomException e)
                        {
                    Console.WriteLine($"{e.Message}");
                }
            }

                    Console.WriteLine("\n");
            }

            Console.WriteLine("\nRegistered Students:\n");

            for (int s = 0; s < studentNumber; s++)
            {
                Console.WriteLine($"Name: {Students[s, 0]}, Grade: {Students[s, 1]}");
                Console.WriteLine();
            }
        }
    }
}