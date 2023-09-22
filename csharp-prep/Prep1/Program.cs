using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");//prep1 start
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}");// $ allows variables in string using {}
        Console.Write("Enter grade percentage: ");//prep2 start
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);// converts string to int
        string letter = "";
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}.");
        if (percent >= 70)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
        Random randomGenerator = new Random();//preps program for random variable prep3 start
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = 99999999;
        while (guess != magicNumber)
        {
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Guessed it");
            }
        }
        List<int> numbers = new List<int>();//prep4start
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number. Enter 0 to exit.");
            string userResponce = Console.ReadLine();
            userNumber = int.Parse(userResponce);
            if (userNumber != 0);
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}.");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}.");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}.");
        DisplayWelcomMessage();//start prep5
        string userName = PromptUserName();
        int unsquared = PromptUserNumber();
        int squaredNumber = SquareNumber(unsquared);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}