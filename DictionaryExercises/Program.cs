using System;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and ID Numbers
            do
            {
                Console.WriteLine("Student: ");
                newStudent = Console.ReadLine();

                if (newStudent != "")
                {
                    Console.WriteLine("ID Number: ");
                    int idNumber = int.Parse(Console.ReadLine());
                    students.Add(idNumber, newStudent);
                }

            } while (!Equals(newStudent, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Value + "'s ID: " + student.Key);
            }
            Console.WriteLine("Number of students in roster: " + students.Count);
        }
    }
}
