using System;
using System.Collections.Generic;
using System.IO;

class JournalEntry {
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
}

class Program {
    static void Main(string[] args) {
        List<string> prompts = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What new thing did I learn today?",
            "What was my biggest challenge today?",
            "What am I grateful for today?",
            "What did I do to take care of myself today?",
            "What was the most meaningful conversation I had today?"
        };

        List<JournalEntry> journal = new List<JournalEntry>();

        while (true) {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("\nEnter choice: ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    JournalEntry entry = new JournalEntry();
                    entry.Date = DateTime.Now;
                    entry.Prompt = prompts[new Random().Next(prompts.Count)];
                    Console.Write(entry.Prompt + " ");
                    entry.Response = Console.ReadLine();
                    journal.Add(entry);
                    break;

                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    foreach (JournalEntry je in journal) {
                        Console.WriteLine($"{je.Date}: {je.Prompt} - {je.Response}");
                    }
                    break;

                case "3":
                    Console.Write("\nEnter filename to save: ");
                    string filename = Console.ReadLine();
                    using (StreamWriter writer = new StreamWriter(filename)) {
                        foreach (JournalEntry je in journal) {
                            writer.WriteLine($"{je.Date};{je.Prompt};{je.Response}");
                        }
                    }
                    Console.WriteLine($"Journal saved to {filename}");
                    break;

                case "4":
                    Console.Write("\nEnter filename to load: ");
                    filename = Console.ReadLine();
                    if (File.Exists(filename)) {
                        journal.Clear();
                        using (StreamReader reader = new StreamReader(filename)) {
                            while (!reader.EndOfStream) {
                                string line = reader.ReadLine();
                                string[] fields = line.Split(';');
                                JournalEntry loadedEntry = new JournalEntry();
                                loadedEntry.Date = DateTime.Parse(fields[0]);
                                loadedEntry.Prompt = fields[1];
                                loadedEntry.Response = fields[2];
                                journal.Add(loadedEntry);
                            }
                        }
                        Console.WriteLine($"Journal loaded from {filename}");
                    } else {
                        Console.WriteLine("File not found");
                    }
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
