namespace UserError;

using System;

class Program
{
    static void Main()
    {
        // Simulate user inputs
        string userInput;

        // Simulate a text-only field where numeric input is entered
        Console.WriteLine("Enter a numeric input (in a text-only field): ");
        userInput = Console.ReadLine() ?? string.Empty;

        // Test for NumericInputError
        if (IsNumeric(userInput))
        {
            NumericInputError numericError = new();
            Console.WriteLine(numericError.UEMessage());
        }

        // Simulate a numeric-only field where text input is entered
        Console.WriteLine("\nEnter a text input (in a numeric-only field): ");
        userInput = Console.ReadLine() ?? string.Empty;

        // Test for TextInputError
        if (!IsNumeric(userInput))
        {
            TextInputError textError = new();
            Console.WriteLine(textError.UEMessage());
        }

        // Simulate an invalid input
        Console.WriteLine("\nEnter an invalid input (empty string): ");
        userInput = Console.ReadLine() ?? string.Empty;

        // Test for InvalidInputError
        if (!IsValidInput(userInput))
        {
            InvalidInputError invalidError = new();
            Console.WriteLine(invalidError.UEMessage());
        }

        // Simulate incomplete form submission
        Console.WriteLine("\nAttempt to submit an incomplete form: ");
        bool isFormComplete = false; // Simulated incomplete form
        if (!isFormComplete)
        {
            IncompleteFormError incompleteError = new();
            Console.WriteLine(incompleteError.UEMessage());
        }

        // Simulate exceeding maximum length
        Console.WriteLine("\nEnter a value exceeding maximum allowed length (more than 10 characters): ");
        userInput = Console.ReadLine() ?? string.Empty;

        // Test for MaxLengthExceededError
        int maxLength = 10; // Simulated maximum allowed length
        if (userInput.Length > maxLength)
        {
            MaxLengthExceededError maxLengthError = new();
            Console.WriteLine(maxLengthError.UEMessage());
        }
    }

    // Function to check if input is numeric
    static bool IsNumeric(string input)
    {
        return int.TryParse(input, out _);
    }

    // Function to check if input is valid (example implementation)
    static bool IsValidInput(string input)
    {
        return !string.IsNullOrEmpty(input);
    }
}
