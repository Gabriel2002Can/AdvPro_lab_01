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

            //reference https://stackoverflow.com/questions/7461080/fastest-way-to-check-if-string-contains-only-digits-in-c-sharp
            bool IsDigitsOnly(string str)
            {
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                        return false;
                }

                return true;
            }

            bool contKey = true;
            bool dayKey = true;
            bool monthKey = true;

            var studentsList = new List<Student>();

            //Temporary var
            string studentName;
            string studentDay;
            string studentMonth;

            Console.WriteLine("Insert the info about the students\n");

            do
            {
                Console.WriteLine("Insert the Student's name:");
                studentName = Console.ReadLine();

                //Day input
                do
                {
                    Console.WriteLine($"In what day {studentName} was born?");

                    studentDay = Console.ReadLine();

                    //Validation
                    if (int.Parse(studentDay) > 31 || int.Parse(studentDay) < 1 || !IsDigitsOnly(studentDay) || string.IsNullOrEmpty(studentDay) )
                    {
                        continue;
                    }
                    dayKey = false;
                }while(dayKey);

                //Month input
                do
                {
                    Console.WriteLine($"In which month {studentName} was born?");

                    studentMonth = Console.ReadLine();

                    //Validation
                    if (int.Parse(studentMonth) > 31 || int.Parse(studentMonth) < 1 || !IsDigitsOnly(studentMonth) || string.IsNullOrEmpty(studentMonth))
                    {
                        continue;
                    }
                    monthKey = false;
                } while (monthKey);

                //Setting student object
                var newStudent = new Student(studentName,int.Parse(studentDay), int.Parse(studentMonth));

                studentsList.Add(newStudent);
                Student.StudentCounter++;

                Console.WriteLine("\nDo you want to stop? (y/*)?");

                string choice = Console.ReadLine();

                if (choice == "y" || choice == "Y")
                {
                    contKey = false;
                }

                Console.WriteLine("\n");

            }while(contKey);

            foreach (var student in studentsList)
            {
                Console.WriteLine($"The student {student.Name} was born in the day {student.Day} of the month {student.Month}, so its zodiac sign is {student.Zodiac}.");
            }
        }
    }

    class Student
    {
        private string name;
        private int day;
        private int month;
        private string zodiac;
        private static int studentCounter = 0;

        //Constructor method
        public Student(string name, int day, int month)
        {
            Name = name;
            Day = day;
            Month = month;

            //For each month
            switch (month)
            {

                case 1:
                    Zodiac =  day <= 19 ? "Capricorn" : "Aquarius";
                    break;
                case 2:
                    Zodiac = day <= 18 ? "Aquarius" : "Pisces";
                    break;
                case 3:
                    Zodiac = day <= 20 ? "Pisces" : "Aries";
                    break;
                case 4:
                    Zodiac = day <= 19 ? "Aries" : "Taurus";
                    break;
                case 5:
                    Zodiac = day <= 20 ? "Taurus" : "Gemini";
                    break;
                case 6:
                    Zodiac = day <= 20 ? "Gemini" : "Cancer";
                    break;
                case 7:
                    Zodiac = day <= 22 ? "Cancer" : "Leo";
                    break;
                case 8:
                    Zodiac = day <= 22 ? "Leo" : "Virgo";
                    break;
                case 9:
                    Zodiac = day <= 22 ? "Virgo" : "Libra";
                    break;
                case 10:
                    Zodiac = day <= 22 ? "Libra" : "Scorpio";
                    break;
                case 11:
                    Zodiac = day <= 21 ? "Scorpio" : "Sagittarius";
                    break;
                case 12:
                    Zodiac = day <= 21 ? "Sagittarius" : "Capricorn";
                    break;
                default:
                    Zodiac = "Invalid Date";
                    break;
            }
        }

        //Setter and Getter for class variables
        public static int StudentCounter
        {
            get { return studentCounter; }
            set { studentCounter = value; }
        }

        public string Zodiac
        {
            get { return zodiac; }
            set { zodiac = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }
    }

}
