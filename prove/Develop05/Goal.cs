// Goal.cs - base class for all goals
public abstract class Goal
{
public string Name { get; set; } // the name of the goal
public int Value { get; set; } // the value the user gains when completing the goal
public int Score { get; set; } // the user's current score for this goal

public abstract void RecordEvent(); // records an event and updates the score
public abstract string GetStatus(); // gets the status of the goal (completed or not)
}