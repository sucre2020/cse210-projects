// EternalGoal.cs - an eternal goal that is never complete, but each time the user records them, they gain some value
public class EternalGoal : Goal
{
public override void RecordEvent()
{
Score += Value;
}

public override string GetStatus()
{
    return "";
}

}