
using System.Data;
using System;
using System.Text;

public class Program
{
    static StringBuilder message = new StringBuilder();


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


        while (true)
        {
            // Get user input
            string input = Console.ReadLine();

            if (input == "#")
                break; // exit the loop

            if (input.Length > 0)
            {
                // Call  ProcessChoice method 
                ProcessChoice(input);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

        }
        Console.WriteLine("the message is " + message.ToString());
    }

    // Method to process the input and print the correct letter
    public static void ProcessChoice(string input)
    {
        // Extract the first character of the input
        char key = input[0];

        // Get the length
        int length = input.Length;

        // Switch statement key 
        string letter = key switch
        {
            '2' => GetLetterKeypad("abc", length),
            '3' => GetLetterKeypad("def", length),
            '4' => GetLetterKeypad("ghi", length),
            '5' => GetLetterKeypad("jkl", length),
            '6' => GetLetterKeypad("mno", length),
            '7' => GetLetterKeypad("pqrs", length),
            '8' => GetLetterKeypad("tuv", length),
            '9' => GetLetterKeypad("wxyz", length),
            _ => "invalid input"
        };
        if (letter == "invalid input")
        {
            Console.WriteLine("invalid input");
        }
        else
        {
            message.Append(letter); //add letter to the message
        }
    }

    // Helper method 
    public static string GetLetterKeypad(string letters, int pressCount)
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