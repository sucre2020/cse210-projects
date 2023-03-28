// SimpleGoal.cs - a goal that can be marked complete and the user gains some value
public class SimpleGoal : Goal
{
public bool IsCompleted { get; set; } // whether the goal is completed or not

public override void RecordEvent()
{
    IsCompleted = true;
    Score += Value;
}

public override string GetStatus()
{
    return IsCompleted ? "[X]" : "[ ]";
}

}