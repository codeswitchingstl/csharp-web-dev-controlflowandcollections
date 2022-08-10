using System;
using System.Collections.Generic;

namespace DictionaryGradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, string> students = new Dictionary<double, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and ID numbers
            do
            {
                Console.WriteLine("Student: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("ID Number: ");
                    input = Console.ReadLine();
                    double idNumber = double.Parse(input);
                    students.Add(idNumber, newStudent);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<double, string> student in students)
            {
                Console.WriteLine(student.Value + " (" + student.Key + ")");
            }
        }
    }
}