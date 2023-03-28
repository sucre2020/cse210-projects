// ChecklistGoal.cs - a checklist goal that must be accomplished a certain number of times to be complete
public class ChecklistGoal : Goal
{
public int TimesCompleted { get; set; } // how many times the goal has been completed
public int RequiredTimes { get; set; } // how many times the goal must be completed to be finished
public int Bonus { get; set; } // the extra bonus the user receives when the goal is completed

public override void RecordEvent()
{
    TimesCompleted++;

    if (TimesCompleted < RequiredTimes)
    {
        Score += Value;
    }
    else if (TimesCompleted == RequiredTimes)
    {
        Score += Value + Bonus;
    }
}

public override string GetStatus()
{
    return $"Completed {TimesCompleted}/{RequiredTimes} times";
}

}