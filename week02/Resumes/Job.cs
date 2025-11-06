using System;
    public class Job
{
    public string _company = ""; // _company is a member variable
    public string _jobTitle = "";
    public string _startYear = "";
    public string _endYear = "";

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    }