using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.IO;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        List<string> facilityUse = new List<string>();
        string track = "";
        while(track != "exit")
        {
            Console.WriteLine("Enter 'run', 'bike', or 'swim' to track an activity.\nEnter 'display' to see entries or 'exit' to finish.");
            track = Console.ReadLine();
            if(track == "run")
            {
                Running run = new Running();
                facilityUse.Add(run.format());
            }
            else if(track == "bike")
            {
                Biking bike = new Biking();
                facilityUse.Add(bike.format());
            }
            else if(track == "swim")
            {
                Swimming swim = new Swimming();
                facilityUse.Add(swim.format());
            }
            else if(track == "display")
            {
                Console.WriteLine(facilityUse);
            }
        }
    }
}
public abstract class Activity
{
    public abstract string format();
}
public class Running: Activity
{
    public override string format()
    {
        Console.WriteLine("Enter distance ran in km.");
        float distance = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter time in minutes spent running.");
        float time = float.Parse(Console.ReadLine());
        float speed = distance / time * 60;
        float pace = time / distance;
        Console.WriteLine("Enter day of run as: day/month/year");
        string day = Console.ReadLine();
        string format = day + " Running (" + time + " min): Distance " + distance + "kmh, Speed " + speed + ", pace " + pace + " min per km.";
        return format;
    }
}
public class Biking: Activity
{
    public override string format()
    {
        Console.WriteLine("Enter distance biked in km.");
        float distance = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter time in minutes spent biking.");
        float time = float.Parse(Console.ReadLine());
        float speed = distance / time * 60;
        float pace = time / distance;
        Console.WriteLine("Enter day of bike run as: day/month/year");
        string day = Console.ReadLine();
        string format = day + " Biking (" + time + " min): Distance " + distance + "kmh, Speed " + speed + ", pace " + pace + " min per km.";
        return format;
    }
}
public class Swimming: Activity
{
    public override string format()
    {
        Console.WriteLine("Enter laps in pool.");
        float laps = float.Parse(Console.ReadLine());
        float distance = laps * 50;
        Console.WriteLine("Enter time in minutes spent swimming.");
        float time = float.Parse(Console.ReadLine());
        float speed = distance / time * 60;
        float pace = time / distance;
        Console.WriteLine("Enter day of swim as: day/month/year");
        string day = Console.ReadLine();
        string format = day + " Swimming (" + time + " min): Laps " + laps + ", Distance " + distance + "kmh, Speed " + speed + ", pace " + pace + " min per km.";
        return format;
    }
}