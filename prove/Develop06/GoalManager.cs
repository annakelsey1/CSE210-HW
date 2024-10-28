using System;
using System.Collections.Generic;
using System.IO;

// Start - This is the "main" function for this class. It is called by Program.cs, and then 
// runs the menu loop.

// DisplayPlayerInfo - Displays the players current score.

// ListGoalNames - Lists the names of each of the goals.

// ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is 
// complete).

// CreateGoal - Asks the user for the information about a new goal. Then, creates the goal 
// and adds it to the list.

// RecordEvent - Asks the user which goal they have done and then records the event by calling 
// the RecordEvent method on that goal.

// SaveGoals - Saves the list of goals to a file.

// LoadGoals - Loads the list of goals from a file.

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
        // Initializes an empty list of goals and sets the player's score to 0
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Add code to start the goal management process
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine($"Total Goals: {_goals.Count}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Goal goal = _goals[i];
                string status = goal.IsComplete() ? "[X]" : "[ ]";

                // If it's an EternalGoal, don't mark it as completed
                if (goal is EternalGoal)
                {
                    status = "[ ]"; // Always show as incomplete for eternal goals
                }

                // Display goal information with points
                Console.WriteLine($"{i + 1}. {status} {goal.GetDetailsString()} (Points: {goal.Points})");
            }
        }
    }






    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreateSimpleGoal();
                break;
            case "2":
                CreateEternalGoal();
                break;
            case "3":
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a valid goal type.");
                break;
        }
    }

    private void CreateSimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points);
        _goals.Add(simpleGoal);

        Console.WriteLine("Simple Goal created successfully.");
    }

    private void CreateEternalGoal()
    {
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
        _goals.Add(eternalGoal);

        Console.WriteLine("Eternal Goal created successfully.");
    }

    private void CreateChecklistGoal()
    {
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, target, bonus);
        _goals.Add(checklistGoal);

        Console.WriteLine("Checklist Goal created successfully.");
    }

    public void RecordEvent()
    {
    Console.WriteLine("The goals are:");
    ListGoalNames(); // Display the list of goals with their status

    Console.Write("Which goal did you accomplish? (Enter the number): ");

    // Read user input and validate it
    if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
    {
        Goal selectedGoal = _goals[goalIndex - 1];
        selectedGoal.RecordEvent(); // Call the RecordEvent method on the selected goal
        
        // Update score and display messages
        int earnedPoints = selectedGoal.Points; // Assuming you have a Points property in Goal
        _score += earnedPoints; // Update the overall score

        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        Console.WriteLine($"You now have {_score} points."); // Display updated score

        // Check if the goal has been completed
        if (selectedGoal.IsComplete())
        {
            Console.WriteLine($"Congratulations! You've completed the goal: {selectedGoal.GetDetailsString()}");
        }
    }
    else
    {
        Console.WriteLine("Invalid goal number. Please try again.");
    }
    }





    public void SaveGoals()
    {
        Console.Write("Enter the filename to save your goals (e.g., goals.txt): ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Write the score first
                writer.WriteLine(_score);
                // Write each goal to the file
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();

    if (File.Exists(filename))
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split('|');

            switch (parts[0])
            {
                case "SimpleGoal":
                    string simpleName = parts[1];
                    string simpleDescription = parts[2];
                    int simplePoints = int.Parse(parts[3]);
                    bool isSimpleComplete = bool.Parse(parts[4]);

                    SimpleGoal simpleGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints);
                    if (isSimpleComplete)
                    {
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);
                    break;

                case "EternalGoal":
                    string eternalName = parts[1];
                    string eternalDescription = parts[2];
                    int eternalPoints = int.Parse(parts[3]);

                    EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);
                    _goals.Add(eternalGoal);
                    break;

                case "ChecklistGoal":
                    string checklistName = parts[1];
                    string checklistDescription = parts[2];
                    int checklistPoints = int.Parse(parts[3]);
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(checklistName, checklistDescription, checklistPoints, target, bonus);
                    for (int i = 0; i < amountCompleted; i++)
                    {
                        checklistGoal.RecordEvent();
                    }
                    _goals.Add(checklistGoal);
                    break;

                default:
                    Console.WriteLine("Unknown goal type in file: " + parts[0]);
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
    else
    {
        Console.WriteLine("File not found. Please ensure the file name is correct.");
    }
    }



    public int Score
    {
        get { return _score; }
    }
}

