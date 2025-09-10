using System;
using System.Collections.Generic;

namespace HomeWork
{
    public class DictionaryTask
    {
        private readonly Dictionary<string, double> _studentGrades;

        public DictionaryTask()
        {
            _studentGrades = new Dictionary<string, double>();
        }

        public void TaskLoop()
        {
            Console.WriteLine("=== Task 2: Student Grades Dictionary ===");
            Console.WriteLine("Type '-exit' to quit this task\n");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add student and grade");
                Console.WriteLine("2. Find student grade");
                Console.WriteLine("3. Show all students");
                Console.WriteLine("Type '-exit' to quit");

                string? choice = Console.ReadLine();

                if (choice == "-exit")
                {
                    Console.WriteLine("Exiting Task 2...");
                    break;
                }

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        FindStudent();
                        break;
                    case "3":
                        ShowAllStudents();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or '-exit'.");
                        break;
                }
            }
        }

        private void AddStudent()
        {
            Console.WriteLine("Enter student name:");
            string? name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid name. Please try again.");
                return;
            }

            Console.WriteLine("Enter student grade (2-5):");
            string? gradeInput = Console.ReadLine();

            if (double.TryParse(gradeInput, out double grade) && grade >= 2 && grade <= 5)
            {
                _studentGrades[name] = grade;
                Console.WriteLine($"Added student '{name}' with grade {grade}.");
            }
            else
            {
                Console.WriteLine("Invalid grade. Grade must be between 2 and 5.");
            }
        }

        private void FindStudent()
        {
            Console.WriteLine("Enter student name to find:");
            string? name = Console.ReadLine();

            if (!string.IsNullOrEmpty(name) && _studentGrades.ContainsKey(name))
            {
                Console.WriteLine($"Student '{name}' has grade: {_studentGrades[name]}");
            }
            else
            {
                Console.WriteLine($"Student with name '{name}' does not exist.");
            }
        }

        private void ShowAllStudents()
        {
            if (_studentGrades.Count == 0)
            {
                Console.WriteLine("No students in the dictionary.");
                return;
            }

            Console.WriteLine("All students and their grades:");
            foreach (var student in _studentGrades)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
        }
    }
}
