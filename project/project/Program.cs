using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Main Menu ===");
                Console.WriteLine("Enter 1, 2, or 3 to check task 1, 2, or 3");
                Console.WriteLine("Enter 'exit' to quit the program");
                
                string? input = Console.ReadLine();

                if (input == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (int.TryParse(input, out int task))
                {
                    switch (task)
                    {
                        case 1:
                            CheckTaskFirst();
                            break;
                        case 2:
                            CheckTaskSecond();
                            break;
                        case 3:
                            CheckTaskThird();
                            break;
                        default:
                            Console.WriteLine("Invalid task number. Please enter 1, 2, or 3.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'exit'.");
                }
            }
        }

        private static void CheckTaskFirst()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }

        private static void CheckTaskSecond()
        {
            var dictionaryTask = new DictionaryTask();
            dictionaryTask.TaskLoop();
        }

        private static void CheckTaskThird()
        {
            var linkedListTask = new DoublyLinkedListTask();
            linkedListTask.TaskLoop();
        }
    }
}