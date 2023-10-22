using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.IO;
class Program
{
        static void Main()
    {
        List<string> _goals = new List<string>();
        int score = 0;
        bool run = true;
        Console.WriteLine("What kind of goal are you checking in on? Enter S, E, or C.");
        string gType = Console.ReadLine();
        while(run == true)
        {
        if(gType == "S" || gType == "s")
        {
            SimpleGoal simpleGTracker = new SimpleGoal();
            string sTitle = simpleGTracker.RecordEvent();
            _goals.Add(sTitle);
            int sComplete = simpleGTracker.IsComplete();
            score += sComplete;
            string sDetails = simpleGTracker.GetDetailsString();
            Console.WriteLine(sTitle + "\n" + sDetails + "\n+" + sComplete);
        }
        else if (gType == "E" || gType == "e")
        {
            EternalGoal eternalGTracker = new EternalGoal();
            string eTitle = eternalGTracker.RecordEvent();
            _goals.Add(eTitle);
            int eComplete = eternalGTracker.IsComplete();
            score += eComplete;
            string eDetails = eternalGTracker.GetDetailsString();
            Console.WriteLine(eTitle + "\n" + eDetails + "\n+" + eComplete);
        }
        else if (gType == "C" || gType == "c")
        {
            ChecklistGoal checklistGTracker = new ChecklistGoal();
            string cTitle = checklistGTracker.RecordEvent();
            _goals.Add(cTitle);
            int cComplete = checklistGTracker.IsComplete();
            score += cComplete;
            string cDetails = checklistGTracker.GetDetailsString();
            Console.WriteLine(cTitle + "\n" + cDetails + "\n+" + cComplete);
        }
        Console.WriteLine("You have entered " + _goals);
        Console.WriteLine("Your score = " + score);
        Console.WriteLine("If you are done entering goals enter ''y''. Or Enter S, E, or C to continue.");
        gType = Console.ReadLine();
        if(gType == "y")
        {
            run = false;
        }
        }
    }
}
public abstract class Goal
{
    public abstract string RecordEvent();

    public abstract int IsComplete();
    public abstract string GetDetailsString();
}
public class SimpleGoal : Goal
{
    public override string RecordEvent()
    {
        Console.WriteLine("Enter goal title.");
        string title = Console.ReadLine();
        return title;
    }
    public override int IsComplete()
    {
        Console.WriteLine("Is this been completed?\nEnter a ''y'' for yes");
        int complete = 0;
        string answer = Console.ReadLine();
        if(answer == "y")
        {
            complete = 1000;
        }
        return complete;
    }
    public override string GetDetailsString()
    {
        Console.WriteLine("Enter a discription of this goal.");
        string discription = Console.ReadLine();
        return discription;
    }
}
public class EternalGoal : Goal
{
    public override string RecordEvent()
    {
        Console.WriteLine("Enter goal title.");
        string title = Console.ReadLine();
        return title;
    }
    public override int IsComplete()
    {
        Console.WriteLine("Has this action been taken in your goal period?\nEnter ''y'' if yes.");
        int complete = 0;
        string answer = Console.ReadLine();
        if(answer == "y")
        {

        }
        return complete;
    }
    public override string GetDetailsString()
    {
        Console.WriteLine("Enter a discription of this goal.");
        string discription = Console.ReadLine();
        return discription;
    }
}
public class ChecklistGoal : Goal
{
    public override string RecordEvent()
    {
        Console.WriteLine("Enter goal title.");
        string title = Console.ReadLine();
        return title;
    }
    public override int IsComplete()
    {
        Console.WriteLine("Enter how many times this task needs to be done.");
        string answer = Console.ReadLine();
        int cGoal = Int32.Parse(answer);
        Console.WriteLine("Enter how many times this task has been done.");
        int complete = 0;
        answer = Console.ReadLine();
        int cComplete = Int32.Parse(answer);
        complete += cComplete * 50;
        if(cGoal == cComplete)
        {
            complete += 500;
        }
        return complete;
    }
    public override string GetDetailsString()
    {
        Console.WriteLine("Enter a discription of this goal.");
        string discription = Console.ReadLine();
        return discription;
    }
}