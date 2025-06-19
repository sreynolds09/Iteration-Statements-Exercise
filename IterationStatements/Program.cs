﻿namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        public static void UpByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static void NumbersAreEqual(int numOne, int numTwo)
        {
            if (numOne == numTwo)
            {
                Console.WriteLine($"{numOne} is equal to {numTwo}");
            }
            else Console.WriteLine($"{numOne} is not equal to {numTwo}");
        }
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static void PositiveOrNegativeNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static void CanVote()
        {
            Console.WriteLine("Enter your age: ");
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);

            while (canParse == false)
            {
                Console.WriteLine("Enter a valid age: ");
                canParse = int.TryParse(Console.ReadLine(), out userAge);
            }

            if (userAge >= 18)
            {
                Console.WriteLine($"{userAge} is old enough to vote");
            }
            else
            {
                Console.WriteLine($"{userAge} is not old enough to vote");
            }

        }


    // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        static void CheckTenRange()
        {
            Console.WriteLine("Please give me a number between -10 and 10");
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);
            while (!canParse)
            {
                Console.WriteLine("Please give me a valid number");
                canParse = int.TryParse(Console.ReadLine(), out userNumber);
            }

            if (userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine($"{userNumber} is within the range of -10 to 10.");
            }
            else
            {
                Console.WriteLine($"{userNumber} is outside the range of -10 to 10.");
            }
        }

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void MultiplyThroughTwelve(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
            }
        }

        // In the Main method below, call each of your methods to test them.
            // Use various test cases to ensure they work as expected.        
            static void Main(string[] args)
            {
                PrintNumbers1000();
                UpByThree();
                NumbersAreEqual(numOne: 4, numTwo: 3);
                PositiveOrNegativeNumber(4);
                CanVote();
                CheckTenRange();
                MultiplyThroughTwelve(10);
                EvenOrOdd(7);

            }
        }
    }
