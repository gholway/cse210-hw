using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static Baseplate run = new Baseplate();
    static void Main()
    {
        run.Execution();
    }
}
public class Baseplate
{
    public void Execution()
    {
        Console.WriteLine("Enter a number for an activity.\n1.Breathing\n2.Reflection\n3.Listing");
        string act = Console.ReadLine();
        bool entryCheck = false;
        while(entryCheck == false)
        {
            if(act == "1")
            {
                Breathing actB = new Breathing();
                string length = Inherit("breathing exercise");
                actB.Breath(length);
                entryCheck = true;
            }
            else if(act == "2")
            {
                Reflection actR = new Reflection();
                string length = Inherit("relecting exercise");
                actR.Reflect(length);
                entryCheck = true;
            }
            else if(act == "3")
            {
                Listing actL = new Listing();
                string length = Inherit("listing exercise");
                actL.List(length);
                entryCheck = true;
            }
            else
            {
                Console.WriteLine("invalid entry enter a number.");
                act = Console.ReadLine();
            }
        }
        Console.WriteLine("Thank you for your time. Have a nice day.");
        System.Threading.Thread.Sleep(6000);
    }
    public string Inherit(string exercise)
    {
        Console.WriteLine($"Welcome to the {exercise}.\nEnter a number for minutes for {exercise}.");
        string length = Console.ReadLine();
        return length;
    }
}
public class Breathing
{
    public void Breath(string length)
    {
        Console.WriteLine($"This will help you relax by breathing slowly for {length} minutes.");
        int time = int.Parse(length)*60000;
        while(time > 0)
        {
            Console.WriteLine("Breath in.\n|||||\n||||||\n||||||||\n||||||||||");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Breath out.\n||||||||\n||||||\n||||\n||");
            System.Threading.Thread.Sleep(3000);
            time -= 6000;
        }
    }
}
public class Reflection
{
    public void Reflect(string length)
    {
        Console.WriteLine($"This will help you reflect on the good effect you have for {length} minutes.");
        int time = int.Parse(length)*60000;
        Random prompt = new Random();
        int pPick = prompt.Next();
        if(pPick == 1)
        {
            Console.WriteLine("Think of when you helped someone.");
        }
        else if(pPick == 2)
        {
            Console.WriteLine("Think of when someone helped you.");
        }
        else if(pPick == 3)
        {
            Console.WriteLine("Think of when you overcome something difficult.");
        }
        else if(pPick == 4)
        {
            Console.WriteLine("Think of when things worked out.");
        }
        pPick = prompt.Next();
        if(pPick == 1)
        {
            Console.WriteLine("How did this help you spirituly?");
        }
        else if(pPick == 2)
        {
            Console.WriteLine("How did this start?");
        }
        else if(pPick == 3)
        {
            Console.WriteLine("How did you feel once it was over?");
        }
        else if(pPick == 4)
        {
            Console.WriteLine("What might've happened if you weren't there?");
        }
        System.Threading.Thread.Sleep(time);
    }
}
public class Listing
{
    public void List(string length)
    {
        Console.WriteLine($"This will help you see the good in your life with a list for {length} minutes.");
        int time = int.Parse(length)*60;
        Random prompt = new Random();
        int pPick = prompt.Next();
        if(pPick == 1)
        {
            Console.WriteLine("List people that are there for you.");
        }
        else if(pPick == 2)
        {
            Console.WriteLine("List oppertunities that lay before you.");
        }
        else if(pPick == 3)
        {
            Console.WriteLine("List your streanths.");
        }
        else if(pPick == 4)
        {
            Console.WriteLine("List trials you've overcome.");
        }
        int listed = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        while (startTime < endTime)
        {
            Console.ReadLine();
            listed += 1;
        }
        Console.WriteLine($"You entered {listed} things.");
    }
}