using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many students are you going to register?");

            var studentNumber = int.Parse(Console.ReadLine());

            var Students = new string[studentNumber, 2];

            Console.WriteLine("\n");

            for (int s = 0; s < studentNumber; s++)
            {

                Console.WriteLine("Input the Student's name:");

                //Name input 
                Students[s, 0] = Console.ReadLine();

                Console.WriteLine($"Input {Students[s,0]}'s grade");

                //Grade input
                Students[s,1] = Console.ReadLine();

                Console.WriteLine("\n");
            }

            Console.WriteLine("\n");

            for (int s = 0; s < studentNumber; s++)
            {
                Console.WriteLine(Students[s,0]);
                Console.WriteLine(Students[s, 1]);

                Console.WriteLine("\n");
            }
        }
    }
}
