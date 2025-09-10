using System;
using System.Text;

namespace HomeWork
{
    internal class Program
    {
        public static string ConcatenateStrings(string firstString, string secondString)
        {
            return firstString + secondString;
        }

        public static string GreetUser(string name, int age)
        {
            return $"Hello, {name}! You are {age} years old.\nWelcome to our program!";
        }

        public static string AnalyzeString(string inputString)
        {
            int characterCount = inputString.Length;
            string upperCase = inputString.ToUpper();
            string lowerCase = inputString.ToLower();
            
            return $"Character count: {characterCount}\nUppercase: {upperCase}\nLowercase: {lowerCase}";
        }

        public static string GetFirstFiveCharacters(string inputString)
        {
            if (inputString.Length >= 5)
            {
                return inputString.Substring(0, 5);
            }
            else
            {
                return inputString;
            }
        }

        public static StringBuilder CombineStringsToBuilder(string[] stringArray)
        {
            StringBuilder builder = new StringBuilder();
            
            for (int i = 0; i < stringArray.Length; i++)
            {
                builder.Append(stringArray[i]);
                
                if (i < stringArray.Length - 1)
                {
                    builder.Append(" ");
                }
            }
            
            return builder;
        }

        public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Testing String Methods ===\n");

            Console.WriteLine("1. Testing ConcatenateStrings:");
            string result1 = ConcatenateStrings("Hello ", "World!");
            Console.WriteLine($"Result: '{result1}'");
            Console.WriteLine($"Expected: 'Hello World!' - {(result1 == "Hello World!" ? "PASS" : "FAIL")}\n");

            Console.WriteLine("2. Testing GreetUser:");
            string result2 = GreetUser("Alice", 25);
            Console.WriteLine($"Result:\n{result2}");
            string expected2 = "Hello, Alice! You are 25 years old.\nWelcome to our program!";
            Console.WriteLine($"Expected format matched: {(result2 == expected2 ? "PASS" : "FAIL")}\n");

            Console.WriteLine("3. Testing AnalyzeString:");
            string result3 = AnalyzeString("Hello World");
            Console.WriteLine($"Result:\n{result3}");
            Console.WriteLine("Expected: Character count, uppercase, and lowercase versions\n");

            Console.WriteLine("4. Testing GetFirstFiveCharacters:");
            string result4a = GetFirstFiveCharacters("Programming");
            string result4b = GetFirstFiveCharacters("Hi");
            Console.WriteLine($"Result for 'Programming': '{result4a}'");
            Console.WriteLine($"Expected: 'Progr' - {(result4a == "Progr" ? "PASS" : "FAIL")}");
            Console.WriteLine($"Result for 'Hi': '{result4b}'");
            Console.WriteLine($"Expected: 'Hi' - {(result4b == "Hi" ? "PASS" : "FAIL")}\n");

            Console.WriteLine("5. Testing CombineStringsToBuilder:");
            string[] testArray = { "Hello", "beautiful", "world", "today" };
            StringBuilder result5 = CombineStringsToBuilder(testArray);
            string result5String = result5.ToString();
            Console.WriteLine($"Result: '{result5String}'");
            Console.WriteLine($"Expected: 'Hello beautiful world today' - {(result5String == "Hello beautiful world today" ? "PASS" : "FAIL")}\n");

            Console.WriteLine("6. Testing ReplaceWords:");
            string result6 = ReplaceWords("Hello world", "world", "universe");
            Console.WriteLine($"Result: '{result6}'");
            Console.WriteLine($"Expected: 'Hello universe' - {(result6 == "Hello universe" ? "PASS" : "FAIL")}");
            
            string result6b = ReplaceWords("The cat and the cat are playing", "cat", "dog");
            Console.WriteLine($"Multiple replacement result: '{result6b}'");
            Console.WriteLine($"Expected: 'The dog and the dog are playing' - {(result6b == "The dog and the dog are playing" ? "PASS" : "FAIL")}\n");

            Console.WriteLine("=== All tests completed ===");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}