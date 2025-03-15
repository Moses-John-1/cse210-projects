using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("\"Date\",\"Prompt\",\"Entry\""); // This where i write CSV Header
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{EscapeCsv(entry._date)},{EscapeCsv(entry._promptText)},{EscapeCsv(entry._entryText)}");
            }
        }
        Console.WriteLine($"Journal saved as CSV to {fileName}. You can open this in Excel.");
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(fileName).Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = ParseCsvLine(line);
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }

        Console.WriteLine($"Journal loaded from {fileName}. You can now view it in Excel.");
    }

    // formatting properly text for CSV
    private string EscapeCsv(string text)
    {
        if (text.Contains(",") || text.Contains("\"") || text.Contains("\n"))
        {
            text = text.Replace("\"", "\"\""); 
            return $"\"{text}\"";
        }
        return text;
    }


    private string[] ParseCsvLine(string line)
    {
        List<string> parts = new List<string>();
        bool inQuotes = false;
        string current = "";

        foreach (char c in line)
        {
            if (c == '"' && (current.Length == 0 || current.Last() != '\\'))
            {
                inQuotes = !inQuotes;
            }
            else if (c == ',' && !inQuotes)
            {
                parts.Add(current);
                current = "";
            }
            else
            {
                current += c;
            }
        }

        parts.Add(current);
        return parts.Select(p => p.Replace("\"\"", "\"")).ToArray();
    }
}
