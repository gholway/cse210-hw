using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Scripture to memorize.");
        string sRef = Console.ReadLine();
        Console.WriteLine("Enter passage text.");
        string sPas = Console.ReadLine();
        scripture script = new scripture();
        script.passage(sPas, sRef);
        word hide = new word();
        hide.hider(sPas, sRef);
    }
}
public class scripture
{
    public void passage(string sPas, string sRef)
    {
        List<string> scripturePassage = new List<string>(sPas.Split(' '));
        Console.WriteLine($"Your Scripture to memorize is: {sRef}\n{sPas}");
    }
}
public class word
{
    public void hider(string sPas, string sRef)
    {
        Console.WriteLine("Press enter for memorization challange.\nEnter quit to exit.\nEnter reference to see unhidden passage and reference.");
        string action = Console.ReadLine();
        bool repeat = false;
        int hidden = 0;
        List<string> hidingPassage = new List<string>(sPas.Split(' '));
        int toHide = 0;
        foreach(string passage in hidingPassage)
        {
            toHide += 1;
        }
        while(hidden < toHide)
        {
            Console.Clear();
            Random wordPicker = new Random(toHide);
            int picked = wordPicker.Next();
            string selection = hidingPassage[picked];
            if(action.ToLower() == "quit")
            {
                toHide = 0;
            }
            else if(action.ToLower() == "reference")
            {
                reference remind = new reference();
                remind.scriptureReferance(sPas, sRef);
                Console.WriteLine("Press enter to continue memorization or quit to exit.");
                action = Console.ReadLine();
            }
            else
            {
                if(selection == "__")
                {
                    repeat = true;
                }
                if(repeat == false)
                {
                    hidingPassage[picked] = "__";
                }
                repeat = false;
                Console.WriteLine("Press enter to continue.\nEnter quit to exit.\nEnter reference to see unhidden passage and reference.");

            }
        }
        System.Environment.Exit(0);
    }
}
public class reference
{
    public void scriptureReferance(string sPas, string sRef)
    {
        Console.WriteLine($"The Scripture book, chapter, and verse(s) are {sRef}\nWhich reads as follows:\n{sPas}");
    }
}
