using System.Diagnostics.Metrics;
using System.IO;
using System.Linq.Expressions;

public class GoalManager {
    private List<Goal> _goals = new List<Goal>();
    private int _score;



    public GoalManager() {
        _score = 0;
    }


    public void Start() {
        Console.Clear();
        string input = "";
        while (input != "7") {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Point Summery");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1") {
                CreateGoal();
            }
            else if (input == "2") {
                ListGoalDetails();
            }
            else if (input == "3") {
                SaveGoals();
            }
            else if (input == "4") {
                LoadGoals();
            }
            else if (input == "5") {
                RecordEvent();
            }
            else if (input == "6") {
                PointSummery();
            }
            else if (input == "7") {
                break;
            }
            else {
                Console.WriteLine("Invalid input.");
            }


        }

    }

    public void PointSummery() {
        Console.WriteLine("Goals completed:");
        int counter = 1;
        foreach (Goal goal in _goals) {
            if (goal.GetPointsGained() > 0) {
                Console.WriteLine($"{counter}. {goal.GetName()} -- Points gained: {goal.GetPointsGained()}");
                counter += 1;
            }
        }
        
    }

    public void DisplayPlayerInfo() {
        Console.WriteLine($"You have {_score} points.\n");

    }

    public void ListGoalNames() {
        int counter = 1;
        foreach (Goal goal in _goals) {
            Console.WriteLine($"{counter}. {goal.GetName()}");
            counter += 1;
        }

    }

    public void ListGoalDetails() {
        int counter = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals) {
            Console.WriteLine($"{counter}. {goal.GetDetailsString()}");
            counter += 1;
        }

    }

    public void CreateGoal() {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
            
            
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1") {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (choice == "2") {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (choice == "3") {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        

    }

    public void RecordEvent() {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int accomplish = int.Parse(Console.ReadLine());

        
            int points = _goals[accomplish - 1].RecordEvent();
            _score += points;

            Console.WriteLine($"Congratulations! You have earned {points} points!");
            Console.WriteLine($"You now have {_score} points.\n");
        
    }

    public void SaveGoals() {
        Console.Write("What is the filename for the goal? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename)) {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals) {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals() {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        

        foreach (string line in lines.Skip(0)) {
            string[] parts = line.Split("|");

            if (parts[0] == "SimpleGoal") {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                simpleGoal.SetBool(bool.Parse(parts[4]));
                simpleGoal.SetPointsGained(int.Parse(parts[5]));
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal") {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                eternalGoal.SetPointsGained(int.Parse(parts[4]));
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal") {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                checklistGoal.SetAmountCompleted(int.Parse(parts[6]));
                checklistGoal.SetPointsGained(int.Parse(parts[7]));
                _goals.Add(checklistGoal);
            }

        }

    }
}