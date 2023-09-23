using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        int choise = 0;
        List<string> jEntrys = new List<string>();
        while (choise != 5)
        {
            Console.WriteLine("Welcome to journal program.\nPlease select one of the following:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            string choiseEntry = Console.ReadLine();
            choise = int.Parse(choiseEntry);
            if (choise == 1)
            {
                string jwrite = jWriter();
                jEntrys.Add(jwrite);
            }
            else if (choise ==2)
            {
                Console.Write($"{jEntrys}");
            }
            else if (choise == 3)
            {
                Console.WriteLine("Enter file to load from.");
                jEntrys = new List<string>();
                string jLoader = Console.ReadLine();
                string[] loadLines = System.IO.File.ReadAllLines(jLoader);
                foreach (string line in loadLines)
                {
                    jEntrys.Add(line);
                }
            }
            else if (choise == 4)
            {
                string jdata = $"{jEntrys}";
                string jsave = jSaver(jdata);
                Console.Write($"A file called {jsave} should by in your filesystem");
            }
            else if (choise == 5)
            {
                Console.Write("Have a nice day.");
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
    static string jWriter()
    {
                string jwrite = "";
                Random randomgenerator = new Random();
                int promptgen = randomgenerator.Next(1,5);
                if (promptgen == 0)
                {
                    Console.WriteLine("What did you do today? ");
                    jwrite = Console.ReadLine();
                }
                else if (promptgen == 1)
                {
                    Console.WriteLine("Where did you go today? ");
                    jwrite = Console.ReadLine();
                }
                else if (promptgen == 2)
                {
                    Console.WriteLine("What was most exiting about today? ");
                    jwrite = Console.ReadLine();
                }
                else if (promptgen == 3)
                {
                    Console.WriteLine("What challange did you overcome today? ");
                    jwrite = Console.ReadLine();
                }
                else if (promptgen == 4)
                {
                    Console.WriteLine("What did someone do for you today?");
                    jwrite = Console.ReadLine();
                }
                else
                {
                    Console.Write("Uh oh.");
                }        
                return jwrite;
    }
    static string jSaver(string jEntrys)
    {
        Console.WriteLine("Enter file save name.");
        string jSave = Console.ReadLine();
        using (StreamWriter Jfile = new StreamWriter(jSave))
        {
            Jfile.WriteLine($"{jEntrys}");
        }
        return jSave;
    }
}