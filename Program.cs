
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
                if (length == 1)
                {
                    Console.WriteLine("a");
                }
                else if (length == 2)
                {
                    Console.WriteLine("b");
                }
                else if (length == 3)
                {
                    Console.WriteLine("c");
                }
                break;

            case '3':
                if (length == 1)
                {
                    Console.WriteLine("d");
                }
                else if (length == 2)
                {
                    Console.WriteLine("e");
                }
                else if (length == 3)
                {
                    Console.WriteLine("f");
                }
                break;

            case '4':
                if (length == 1)
                {
                    Console.WriteLine("g");
                }
                else if (length == 2)
                {
                    Console.WriteLine("h");
                }
                else if (length == 3)
                {
                    Console.WriteLine("i");
                }
                break;

            case '5':
                if (length == 1)
                {
                    Console.WriteLine("j");
                }
                else if (length == 2)
                {
                    Console.WriteLine("k");
                }
                else if (length == 3)
                {
                    Console.WriteLine("l");
                }
                break;

            case '6':
                if (length == 1)
                {
                    Console.WriteLine("m");
                }
                else if (length == 2)
                {
                    Console.WriteLine("n");
                }
                else if (length == 3)
                {
                    Console.WriteLine("o");
                }
                break;

            case '7':
                if (length == 1)
                {
                    Console.WriteLine("p");
                }
                else if (length == 2)
                {
                    Console.WriteLine("q");
                }
                else if (length == 3)
                {
                    Console.WriteLine("r");
                }
                 else if (length == 4)
                {
                    Console.WriteLine("s");
                }
                break;  

            case '8':
                if (length == 1)
                {
                    Console.WriteLine("t");
                }
                else if (length == 2)
                {
                    Console.WriteLine("u");
                }
                else if (length == 3)
                {
                    Console.WriteLine("v");
                }
                break;    

            case '9':
                if (length == 1)
                {
                    Console.WriteLine("w");
                }
                else if (length == 2)
                {
                    Console.WriteLine("x");
                }
                else if (length == 3)
                {
                    Console.WriteLine("y");
                }
                 else if (length == 3)
                {
                    Console.WriteLine("z");
                }
                break;    
                

            default:
                Console.WriteLine("Invalid input.");
                break;
        }

    }
}
