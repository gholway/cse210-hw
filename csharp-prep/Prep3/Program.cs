using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
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
    }
}