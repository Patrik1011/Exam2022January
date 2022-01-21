using System;

namespace ExamFirstSemester
{
    public static class Helpers
    {
        public static void PrintHelp(string headline, string body, int count, DateTime date)
        {
            Console.WriteLine($"--------{headline.ToUpper()}--------");
            Console.WriteLine(body);
            Console.WriteLine("Count: " + count + " " + date);
            Console.WriteLine("-------------------------\n");
        }
    }

    
}