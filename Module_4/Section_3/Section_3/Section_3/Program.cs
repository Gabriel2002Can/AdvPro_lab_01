using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_3
{
    enum School
    {
        Hogwarts,
        Harvard,
        MIT
    }

    interface IGraduate
    {
        void Graduate();
    }

    class Registrar
    {
        private List<IGraduate> grads;

        public Registrar(List<IGraduate> grads)
        {
            this.grads = grads;
        }

        public void GraduateAll()
        {
            Console.WriteLine("Graduating all students:");
            foreach (var grad in grads)
            {
                grad.Graduate();
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {


                var adding = true;

                List<Student> students = new List<Student>();

                while (adding)
                {
                    try
                    {
                        var newStudent = new Student();

                        newStudent.Name = Util.Console.Ask("Student Name: ");

                        newStudent.Grade = Util.Console.AskInt("Student Grade: ");

                        newStudent.School = (School)Util.Console.AskInt("School Name (type the corresponding number): \n 0: Hogwarts High \n 1: Harvard \n 2: MIT \n)");

                        newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                        newStudent.Address = Util.Console.Ask("Student Address: ");

                        newStudent.Phone = Util.Console.AskInt("Student Phone Number: ");

                        students.Add(newStudent);
                        Student.Count++;
                        Console.WriteLine("Student Count: {0}", Student.Count);

                        Console.WriteLine("Add another? y/n");

                        if (Console.ReadLine() != "y")
                            adding = false;
                    }
                    catch (FormatException msg)
                    {
                        Console.WriteLine(msg.Message);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error adding student, Please try again");
                    }
                }

                foreach (var student in students)
                {
                    Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                }
                Exports(students);

                foreach (var student in students)
                {
                    student.Graduate();
                }
            }

            private static void Exports(List<Student> students)
            {
                foreach (var student in students)
                {
                    switch (student.School)
                    {
                        case School.Hogwarts:
                            Console.WriteLine("Exporting to Hogwarts");
                            break;
                        case School.Harvard:
                            Console.WriteLine("Exporting to Harvard");
                            break;
                        case School.MIT:
                            Console.WriteLine("Exporting to MIT");
                            break;
                    }
                }
            }
            static void Import()
            {
                var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
                Console.WriteLine(importedStudent.Name);
            }

        }
    }
}

