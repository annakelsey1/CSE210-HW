using System;
// RecordEvent - This method should do whatever is necessary for each specific kind of goal, 
// such as marking a simple goal complete and adding to the number of times a checklist goal 
// has been completed. It should return the point value associated with recording the event 
// (keep in mind that it may contain a bonus in some cases if a checklist goal was just 
// finished, for example).

// IsComplete - This method should return true if the goal is completed. The way you 
// determine if a goal is complete is different for each type of goal.

// GetDetailsString - This method should return the details of a goal that could be shown 
// in a list. It should include the checkbox, the short name, and description. Then in the 
// case of the ChecklistGoal class, it should be overridden to shown the number of times the 
// goal has been accomplished so far.

// GetStringRepresentation - This method should provide all of the details of a goal in a way 
// that is easy to save to a file, and then load later.

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) 
        : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
    return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}
