
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the message system of the phone nokia, in order to write a letter please press a number");
        Console.WriteLine("2.abc:");
        Console.WriteLine("3.def:");
        Console.WriteLine("4.ghi");
        Console.WriteLine("5.jkl");
        Console.WriteLine("6.mno");
        Console.WriteLine("7.pqrs");
        Console.WriteLine("8.tuv");
        Console.WriteLine("9.wxyz");
        Console.WriteLine("Press # to finish the sequence");



        // Get user input
        string input = Console.ReadLine();

        // Check if input length is greater than 0
        if (input.Length > 0)
        {
            // Call the ProcessChoice method with the user input
            ProcessChoice(input);
        }
        else 
        {
            Console.WriteLine("Invalid input.");
        }
        
    }

    // Method to process the input and print the correct letter
    private static void ProcessChoice(string input)
    {
        // Extract the first character of the input
        char key = input[0];

        // Get the length of the input
        int length = input.Length;

        // Switch based on the first key pressed
        switch (key)
        {
            case '2':
            Console.WriteLine(GetLetterKeypad("abc", length));  // Calls GetLetterKeypad
            break;
            
            
            case '3':
               Console.WriteLine(GetLetterKeypad("def", length));  
            break;

            case '4':
               Console.WriteLine(GetLetterKeypad("hij", length));  
            break;

            case '5':
                Console.WriteLine(GetLetterKeypad("jkl", length));  
            break;

            case '6':
                Console.WriteLine(GetLetterKeypad("mno", length));  
            break;

            case '7':
                Console.WriteLine(GetLetterKeypad("pqrs", length)); 
            break;

            case '8':
                Console.WriteLine(GetLetterKeypad("tuv", length));  
            break;

            case '9':
               Console.WriteLine(GetLetterKeypad("wxyz", length)); 
            break;        

            default:
                Console.WriteLine("Invalid input.");
                break;
        }

    }

   // Helper method 
    private static string GetLetterKeypad(string letters, int pressCount)
    {
        if (pressCount > 0 && pressCount <= letters.Length)
        {
            return letters[pressCount - 1].ToString();
        }
        else
        {
            return "Invalid input.";
        }
    }
}
  