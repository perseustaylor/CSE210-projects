using System;
public class Job
{
    public string _companyName;
    public string _title;
    public int _startDate;
    public int _endDate;

    public void Display()
    {
        Console.WriteLine($"{_companyName}\n{_title}\nFrom: {_startDate} to {_endDate}");
    }
}