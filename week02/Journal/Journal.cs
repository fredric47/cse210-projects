using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;

public class Journal
{
    public List<string> _entries = new List<string>();

    public void ClearList()
    {
        _entries.Clear();
        _entries.TrimExcess();
    }

    public void AddEntry(string newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine($"{entry}");
        }

    }

    public void SaveToFile(string file)
    {
        Console.WriteLine($"Saving to: {file}");

        using (StreamWriter outPutFile = new StreamWriter(file, true)) // , true  %]
        {
            foreach (string line in _entries)
            {
                outPutFile.WriteLine(line);
            }

        }
    }

    public void LoadFromFile(string file)
    {
        string fileName = file;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

}
 