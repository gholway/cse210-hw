using System;
using System.Collections.Generic;

private class scripture
{
    private void passage(string sPas, string sRef)
    {
        List<string> scripturePassage = new List<string>(sPas.parse);
        Console.WriteLine($"Your Scripture to memorize is: {sRef}\n{sPas}");
    }
}
private class word
{
    private void hider(string sPas, string sRef)
    {
        Console.WriteLine("Press enter for memorization challange.\nEnter quit to exit.\nEnter reference to see unhidden passage and reference.");
        string action = Console.ReadLine();
        bool repeat = false;
        int hidden = 0;
        List<string> hidingPassage = new List<string>(sPas.parse);
        int toHide = hidingPassage.count;
        while(hidden < toHide)
        {
            Console.Clear();
            Random wordPicker = new Random(0, toHide);
            int picked = wordPicker;
            string selection = hidingPassage.index(picked);
            if(action.lower == "quit")
            {
                toHide = 0;
            }
            else if(action.lower == "reference")
            {
                reference.scriptureReferance(sPas, sRef);
                Console.WriteLine("Press enter to continue memorization or quit to exit.")
                string action = Console.ReadLine();
            }
            else
            {
                if(selection == "__")
                {
                    repeat = true
                }
                if(repeat == false)
                {
                    hidingPassage.index(picked) = "__";
                }
                repeat = false;
                Console.WriteLine("Press enter to continue.\nEnter quit to exit.\nEnter reference to see unhidden passage and reference.");

            }
        }
        this.Close();
    }
}
private class reference
{
    private void scriptureReferance(string sPas, string sRef)
    {
        Console.WriteLine($"The Scripture book, chapter, and verse(s) are {sRef}\nWhich reads as follows:\n{sPas}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Scripture to memorize.");
        string sRef = Console.ReadLine();
        Console.WriteLine("Enter passage text.");
        string sPas = Console.ReadLine();
        scripture.passage(sPas, sRef);
        word.hider(sPas, sRef);
    }
}
