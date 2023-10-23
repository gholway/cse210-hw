using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.IO;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        List<string> events = new List<string>();
        string plan = "";
        while(plan != "finish")
        {
            Console.WriteLine("Enter 'lecture', 'reception', or 'outdoor' to plan an event or enter 'finish' to exit.\nIf you wish to see the planned events enter 'display'");
            plan = Console.ReadLine();
            if(plan == "lecture")
            {
                Lecture LPlan = new Lecture();
                Console.WriteLine("Do you want to make a 'normal', 'long', or 'short' discription?");
                plan = Console.ReadLine();
                if(plan == "normal")
                {
                    string addition = LPlan.Details();
                    events.Add(addition);
                }
                else if(plan == "long")
                {
                    string addition = LPlan.MDetails();
                    events.Add(addition);
                }
                else if(plan == "short")
                {
                    string addition = LPlan.Description();
                    events.Add(addition);
                }
            }
            else if(plan == "reception")
            {
                Reception RPlan = new Reception();
                Console.WriteLine("Do you want to make a 'normal', 'long', or 'short' discription?");
                plan = Console.ReadLine();
                if(plan == "normal")
                {
                    string addition = RPlan.Details();
                    events.Add(addition);
                }
                else if(plan == "long")
                {
                    string addition = RPlan.MDetails();
                    events.Add(addition);
                }
                else if(plan == "short")
                {
                    string addition = RPlan.Description();
                    events.Add(addition);
                }
            }
            else if(plan == "outdoor")
            {
                OutdoorGathering OPlan = new OutdoorGathering();
                Console.WriteLine("Do you want to make a 'normal', 'long', or 'short' discription?");
                plan = Console.ReadLine();
                if(plan == "normal")
                {
                    string addition = OPlan.Details();
                    events.Add(addition);
                }
                else if(plan == "long")
                {
                    string addition = OPlan.MDetails();
                    events.Add(addition);
                }
                else if(plan == "short")
                {
                    string addition = OPlan.Description();
                    events.Add(addition);
                }
            }
            else if(plan == "display")
            {
                Console.WriteLine(events);
            }
        }
    }
}
public abstract class Event
{
    public abstract string Details();
    public abstract string MDetails();
    public abstract string Description();
}
public class Lecture: Event
{
    public override string Details()
    {
        Console.WriteLine("Enter the title of the event.");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the day and time the event will take place.");
        string time = Console.ReadLine();
        Address sAddress = new Address();
        string place = sAddress.SAddress();
        Console.WriteLine("Enter discription.");
        string discription = Console.ReadLine();
        string format = "title: " + title + "\n" + discription + "\nWill be on " + time + "\nAt: " + place;
        return format;
    }
    public override string MDetails()
    {
        string type = "lecture";
        Console.WriteLine("Enter the title of the event.");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the day and time the event will take place.");
        string time = Console.ReadLine();
        Address sAddress = new Address();
        string place = sAddress.SAddress();
        Console.WriteLine("Enter short discription.");
        string discription = Console.ReadLine();
        Console.WriteLine("Enter speaker name.");
        string speaker = Console.ReadLine();
        Console.WriteLine("Enter how many people can attend.");
        string capasity = Console.ReadLine();
        string format = "title:" + title + "\nEvent type: " + type + "\nBy: " + speaker + "\n" + discription + "\nWill be on " + time + "\nAt: " + place + "\nThere are " + capasity + " seats avaible.";
        return format;
    }
    public override string Description()
    {
        string type = "lecture";
        Console.WriteLine("Enter the title of the event.");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the day this will take place.");
        string day = Console.ReadLine();
        string format = "Event type: " + type + "\ntitle: " + title + "\nOn: " + day;
        return format;
    }
}
public class Reception: Event
{
    public override string Details()
    {
        Console.WriteLine("Enter the title of the event.");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the day and time the event will take place.");
        string time = Console.ReadLine();
        Address sAddress = new Address();
        string place = sAddress.SAddress();
        Console.WriteLine("Enter short discription.");
        string discription = Console.ReadLine();
        string format = "title:" + title + "\n" + discription + "\nWill be on " + time + "\nAt: " + place;
        return format;
    }
    public override string MDetails()
    {
        string type = "reception";
        Console.WriteLine("Enter the title of the event.");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the day and time the event will take place.");
        string time = Console.ReadLine();
        Address sAddress = new Address();
        string place = sAddress.SAddress();
        Console.WriteLine("Enter short discription.");
        string discription = Console.ReadLine();
        Console.WriteLine("Enter how many people can attend.");
        string capasity = Console.ReadLine();
        Console.WriteLine("Enter email for RSVP.");
        string email = Console.ReadLine();
        string format = "title:" + title + "\n" + type + "\n" + discription + "\nWill be on " + time + "\nAt: " + place + "\nThere are " + capasity + " seats avaible visit " + email + " to enter your reservation.";
        return format;
    }
    public override string Description()
    {
        string type = "reception";
        Console.WriteLine("Enter the title of the event.");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the day this will take place.");
        string day = Console.ReadLine();
        string format = "Event type: " + type + "\ntitle: " + title + "\nOn: " + day;
        return format;
    }
}
public class OutdoorGathering: Event
{
    public override string Details()
    {
        Console.WriteLine("Enter the title of the event.");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the day and time the event will take place.");
        string time = Console.ReadLine();
        Address sAddress = new Address();
        string place = sAddress.SAddress();
        Console.WriteLine("Enter short discription.");
        string discription = Console.ReadLine();
        string format = "title:" + title + "\n" + discription + "\nWill be on " + time + "\nAt: " + place;
        return format;
    }
    public override string MDetails()
    {
        string type = "outdoor gathering";
        Console.WriteLine("Enter the title of the event.");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the day and time the event will take place.");
        string time = Console.ReadLine();
        Address sAddress = new Address();
        string place = sAddress.SAddress();
        Console.WriteLine("Enter short discription.");
        string discription = Console.ReadLine();
        Console.WriteLine("Enter expected weather during the event.");
        string weather = Console.ReadLine();
        string format = "title:" + title + "\n" + type + "\n" + discription + "\nWill be on " + time + "\nAt: " + place + "\nIt expected to be " + weather + " during this event.";
        return format;
    }
    public override string Description()
    {
        string type = "outdoor gathering";
        Console.WriteLine("Enter the title of the event.");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the day this will take place.");
        string day = Console.ReadLine();
        string format = "Event type: " + type + "\ntitle: " + title + "\nOn: " + day;
        return format;
    }
}
public class Address
{
    public string SAddress()
    {
        Console.WriteLine("Enter address of event.");
        string sAddress = Console.ReadLine();
        return sAddress;
    }
}