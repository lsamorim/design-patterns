﻿using System.Diagnostics;

namespace SOLID.SingleResponsability
{
    public static class SingleResponsabilityExample
    {
        public static string Title = "Single Responsability Principle";

        public static void Execute()
        {
            Console.WriteLine($"*** Start: {Title} ***\n");

            // Bad
            Console.WriteLine($"** Bad approach **\n");
            var badJournal = new BadJournal();
            badJournal.AddEntry("I have studied some new bad language");
            badJournal.AddEntry("I took a walk with my dog");

            var badFilename = @"c:\temp\bad-journal-file.txt";
            badJournal.Save(badFilename);
            Console.WriteLine(badJournal);

            Console.ReadKey();

            // Good
            Console.WriteLine($"\n** Good approach **\n");
            var journal = new Journal();
            journal.AddEntry("I have studied some new language");
            journal.AddEntry("I took a walk with my two dogs");

            var journalPersistence = new JournalPersistence();
            var filename = @"c:\temp\good-journal-file.txt";
            journalPersistence.Save(journal, filename, true);
            Console.WriteLine(journal);
            Process.Start(new ProcessStartInfo("cmd", $"/c start {filename}"));

            Console.WriteLine($"\n*** End: {Title} ***\n");
            Console.ReadKey();
        }
    }
}
