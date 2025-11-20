using System;

abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _IsComplete;

    public Goal(string name, string description, int points)
    {
        _IsComplete = false;
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public void CompleteGoal()
    {
        _IsComplete = true;
    }

    public bool IsComplete()
    {
        return _IsComplete;
    }

    public abstract int RecordEvent();

    public virtual string GetEvent()
    {
        string checkbox = _IsComplete ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_description})";
    }
    
    public virtual string GetstringRepresentation()
    {
        return $"{this.GetType().Name}:{_name}|{_description}|{_points}|{_IsComplete}";
    }
}
