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
    }
}