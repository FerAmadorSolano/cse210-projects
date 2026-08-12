using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Load Goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                RecordEvent();
            }
            else if (choice == "4")
            {
                SaveGoals();
            }
            else if (choice == "5")
            {
                LoadGoals();
            }
            else if (choice == "6")
            {
                running = false;
                Console.WriteLine("Thank you for use :)");
            }
            else
            {
                Console.WriteLine("Invalid choice :( Try Again!");
            }
            
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals yet.");
            return;
        }

        Console.WriteLine("Your Goals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (type == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be completed? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for completing it? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal =
                new ChecklistGoal(name, description, points, target, bonus);

            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals.");
            return;
        }

        ListGoalDetails();

        Console.Write("Which goal did you accomplish? ");
        int number = int.Parse(Console.ReadLine());

        if (number < 1 || number > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = _goals[number - 1];

        if (goal is SimpleGoal && goal.IsComplete())
        {
            Console.WriteLine("This goal is already complete.");
            return;
        }

        int pointsEarned = goal.GetPoints();

        goal.RecordEvent();

        _score += pointsEarned;

        if (goal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete())
            {
                _score += checklist.GetBonus();
                Console.WriteLine(
                    $"Congratulations! You completed the checklist and earned {checklist.GetBonus()} bonus points!"
                );
            }
        }

        Console.WriteLine($"You earned {pointsEarned} points!");
        Console.WriteLine($"Your total score is {_score}.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                int points = int.Parse(parts[2]);
                bool complete = bool.Parse(parts[3]);

                SimpleGoal goal = new SimpleGoal(name, "", points);

                if (complete)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                int points = int.Parse(parts[2]);

                EternalGoal goal = new EternalGoal(name, "", points);

                _goals.Add(goal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                int points = int.Parse(parts[2]);
                int target = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);

                ChecklistGoal goal =
                    new ChecklistGoal(name, "", points, target, bonus);

                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}
