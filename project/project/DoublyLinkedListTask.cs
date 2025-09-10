using System;

namespace HomeWork
{
    public class DoublyLinkedListTask
    {
        private class Node
        {
            public string Data { get; set; }
            public Node? Next { get; set; }
            public Node? Previous { get; set; }

            public Node(string data)
            {
                Data = data;
                Next = null;
                Previous = null;
            }
        }

        private Node? _head;
        private Node? _tail;

        public void TaskLoop()
        {
            Console.WriteLine("=== Task 3: Doubly Linked List ===");
            Console.WriteLine("Type '-exit' to quit this task\n");

            Console.WriteLine("Enter 3 to 6 elements for the doubly linked list:");
            int elementCount = 0;

            while (elementCount < 6)
            {
                Console.WriteLine($"Enter element {elementCount + 1} (or '-exit' to quit, 'done' when finished with at least 3 elements):");
                string? input = Console.ReadLine();

                if (input == "-exit")
                {
                    Console.WriteLine("Exiting Task 3...");
                    return;
                }

                if (input == "done")
                {
                    if (elementCount >= 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You need to enter at least 3 elements. Continue entering...");
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(input))
                {
                    Add(input);
                    elementCount++;
                    Console.WriteLine($"Added '{input}' to the list. Total elements: {elementCount}");

                    if (elementCount >= 3)
                    {
                        Console.WriteLine("You can type 'done' to finish or continue adding (max 6 total).");
                    }
                }
            }

            Console.WriteLine("\nList in forward order:");
            PrintForward();

            Console.WriteLine("\nList in reverse order:");
            PrintReverse();

            Console.WriteLine("\nTask 3 completed. Type any key to return to main menu.");
            Console.ReadKey();
        }

        private void Add(string data)
        {
            Node newNode = new Node(data);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail!.Next = newNode;
                newNode.Previous = _tail;
                _tail = newNode;
            }
        }

        private void PrintForward()
        {
            Node? current = _head;
            while (current != null)
            {
                Console.Write(current.Data);
                if (current.Next != null)
                    Console.Write(" -> ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        private void PrintReverse()
        {
            Node? current = _tail;
            while (current != null)
            {
                Console.Write(current.Data);
                if (current.Previous != null)
                    Console.Write(" -> ");
                current = current.Previous;
            }
            Console.WriteLine();
        }
    }
}
