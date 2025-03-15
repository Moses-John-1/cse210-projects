using System;

class Program

/*
   I Exceed Requirements:
   This is what i do:
    ↣ Saves the journal as a CSV file so it can be open in Excel.  
    ↣ Handle commas and quotes properly to avoid formatting issues.  
    ↣ Makes it easier to read and edit journal entries.  
*/
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                Entry newEntry = new Entry(date, prompt, response);
                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry saved.");
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save journal (e.g., journal.csv): ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load journal (e.g., journal.csv): ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}
