class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points; 
    }

    public override string GetEvent()
    {
        return $"[ ] {_name} ({_description})";  
    }

    public override string GetstringRepresentation()
    {
        return $"EternalGoal:{_name}|{_description}|{_points}|{_IsComplete}";
    }
}
