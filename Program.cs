using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        try
        {
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid integer values.");
            return;
        }

        int choice;
        do
        {
            Console.WriteLine("\nEnter Your Option (1-5):\n" +
                              "1. Add\n" +
                              "2. Multiply\n" +
                              "3. Odd / Even\n" +
                              "4. Display Range\n" +
                              "5. Exit");

            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddNumbers(num1, num2);
                    break;
                case 2:
                    MultiplyNumbers(num1, num2);
                    break;
                case 3:
                    OddOrEven(num1, num2);
                    break;
                case 4:
                    DisplayRange(num1, num2);
                    break;
                case 5:
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        } while (choice != 5);
    }

    static void AddNumbers(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
    }

    static void MultiplyNumbers(int num1, int num2)
    {
        int product = num1 * num2;
        Console.WriteLine($"Product of {num1} and {num2} is: {product}");
    }

    static void OddOrEven(int num1, int num2)
    {
        string num1Message = num1 % 2 == 0 ? "even" : "odd";
        string num2Message = num2 % 2 == 0 ? "even" : "odd";

        Console.WriteLine($"{num1} is {num1Message} and {num2} is {num2Message}.");
    }

    static void DisplayRange(int num1, int num2)
    {
        Console.WriteLine($"Range of integers between {num1} and {num2}:");
        if (num1 <= num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = num1; i >= num2; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}