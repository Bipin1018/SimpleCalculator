using System;

class SimpleCalculator
{
    // Function to select operation
    static int SelectOperation()
    {
        int operation;
        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");

            if (int.TryParse(Console.ReadLine(), out operation) && operation >= 1 && operation <= 4)
            {
                return operation;
            }
            else
            {
                Console.WriteLine("Invalid input. Please select a valid operation (1-4).");
            }
        }
    }

    // Function to ask for a valid number
    static double AskNumber(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    // Functions for performing calculations
    static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error! Division by zero.");
            return double.NaN; // Return "Not a Number" when divided by zero
        }
        return num1 / num2;
    }

    // Function to print the result with the operation
    static void PrintResult(double num1, double num2, double result, string operation)
    {
        if (!double.IsNaN(result))
        {
            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
        }
    }

    // Main function to run the calculator
    static void Main()
    {
        // Select operation
        int operation = SelectOperation();

        // Input numbers
        double num1 = AskNumber("Enter the first number: ");
        double num2 = AskNumber("Enter the second number: ");

        // Perform the selected operation and print the result
        switch (operation)
        {
            case 1:
                PrintResult(num1, num2, Add(num1, num2), "+");
                break;
            case 2:
                PrintResult(num1, num2, Subtract(num1, num2), "-");
                break;
            case 3:
                PrintResult(num1, num2, Multiply(num1, num2), "*");
                break;
            case 4:
                PrintResult(num1, num2, Divide(num1, num2), "/");
                break;
        }
    }
}
