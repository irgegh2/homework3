using System;
using System.Collections.Generic;

namespace HomeWork
{
    public class ListTask
    {
        private readonly List<string> _listOfStrings;

        public ListTask()
        {
            _listOfStrings = new List<string>();
        }

        public void TaskLoop()
        {
            Console.WriteLine("=== Task 1: Working with List<string> ===");
            Console.WriteLine("Type '-exit' to quit this task\n");

            // Add initial elements
            _listOfStrings.Add("Apple");
            _listOfStrings.Add("Banana");
            _listOfStrings.Add("Cherry");
            Console.WriteLine("Initial list created with: Apple, Banana, Cherry");

            while (true)
            {
                Console.WriteLine("\nCurrent list contents:");
                for (int i = 0; i < _listOfStrings.Count; i++)
                {
                    Console.WriteLine($"{i}: {_listOfStrings[i]}");
                }

                Console.WriteLine("\nEnter a new string to add to the list (or '-exit' to quit):");
                string? input = Console.ReadLine();

                if (input == "-exit")
                {
                    Console.WriteLine("Exiting Task 1...");
                    break;
                }

                if (!string.IsNullOrEmpty(input))
                {
                    _listOfStrings.Add(input);
                    Console.WriteLine($"Added '{input}' to the list.");

                    Console.WriteLine("\nEnter another string to add to the middle of the list:");
                    string? middleInput = Console.ReadLine();

                    if (middleInput == "-exit")
                    {
                        Console.WriteLine("Exiting Task 1...");
                        break;
                    }

                    if (!string.IsNullOrEmpty(middleInput))
                    {
                        int middleIndex = _listOfStrings.Count / 2;
                        _listOfStrings.Insert(middleIndex, middleInput);
                        Console.WriteLine($"Added '{middleInput}' to the middle of the list at index {middleIndex}.");
                    }
                }
            }
        }
    }
}
