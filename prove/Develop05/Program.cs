using System;
using System.Reflection.Metadata;

abstract class Goal
{
    public void RecordEvent()
    {
        return;
    }
    public bool IsComplete()
    {
        bool complete = false;
        return complete;
    }
    string GetDetailsString()
    {
        string details = "";
        return details;
    }
    public string GetStringRepresentation()
    {
        string placehold = "";
        return placehold;
    }
}
class SimpleGoal
{
    public override void RecordEvent()
    {
    }
    override bool IsComplete()
    {
    }
    override string GetStringRepresentation()
    {
    }
}
class EternalGoal
{
    override void RecordEvent()
    {
    }
    override bool IsComplete()
    {
    }
    override string GetStringRepresentation()
    {
    }
}
class ChecklistGoal
{
    override void RecordEvent()
    {
    }
    override bool IsComplete()
    {
    }
    override string GetDetailsString()
    {
    }
    override string GetStringRepresentation()
    {
    }
}
class GoalManager
{
    List<string> _goals = new List<string>();
    int _score = 0;
}