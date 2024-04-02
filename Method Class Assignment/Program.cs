using System;

// Define a class named MathOperations
class MathOperations
{
    // Define a void method named PerformOperation that takes two integers as parameters
    public void PerformOperation(int num1, int num2)
    {
        // Perform a math operation on the first integer (just a placeholder operation for demonstration)
        int result = num1 * 2;

        // Display the second integer to the screen
        Console.WriteLine($"Result of operation: {result}, Second integer: {num2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        MathOperations math = new MathOperations();

        // Call the PerformOperation method in the class, passing in two numbers
        math.PerformOperation(5, 10);

        // Call the PerformOperation method in the class, specifying the parameters by name
        math.PerformOperation(num1: 3, num2: 7);
    }
}
