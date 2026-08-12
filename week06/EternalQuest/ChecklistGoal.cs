using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override string GetDetailsString()
    {
        if (_amountCompleted == _target)
        {
            return $"[X] {GetName()} -- Completed {_amountCompleted}/{_target} times";
        }
        else
        {
            return $"[ ] {GetName()} -- Completed {_amountCompleted}/{_target} times";
        }

    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }
}