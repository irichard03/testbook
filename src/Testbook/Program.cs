using System;
using System.Collections.Generic;

namespace Testbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testbook program");
            TestGrades history = new TestGrades("History");
            history.scores.Add(97.50);
            history.scores.Add(75.50);
            history.scores.Add(53.33);
            double lowScore = history.lowScore();
            double highScore = history.highScore();
            double average = history.average();
            Console.WriteLine($"Scores for {history.name} class.\n{history.scores.Count} students took the test.\nThe highest score was {highScore}\nThe lowest score was {lowScore}\nThe average score was {average}");
        }
    }
}
