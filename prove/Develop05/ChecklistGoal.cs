class ChecklistGoal : Goal
{
    private int _TargetNumber;
    protected int _CurrentNumber;
    private int _BonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetNumber, int bonusPoints)
        : base(name, description, points)
    {
        _TargetNumber = targetNumber;
        _CurrentNumber = 0;
        _BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_IsComplete)
        {
            return 0;
        }

        _CurrentNumber++;

        if (_CurrentNumber >= _TargetNumber)
        {
            CompleteGoal();
            return _points + _BonusPoints;
        }

        return _points;
    }

    public void SetCurrentNumber(int number)
    {
        _CurrentNumber = number;
    }

    public override string GetEvent()
    {
        string checkbox = _IsComplete ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_description}) -- completed: {_CurrentNumber}/{_TargetNumber}";
    }

    public override string GetstringRepresentation()
    {
        return $"ChecklistGoal:{_name}|{_description}|{_points}|{_IsComplete}|{_CurrentNumber}|{_TargetNumber}|{_BonusPoints}";
    }
}
