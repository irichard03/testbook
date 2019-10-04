using System;
using System.Collections.Generic;

namespace Testbook
{
    public class TestGrades
    {
        public List<double> scores = new List<double>();
        public string name;

        //constructor
        public TestGrades(string course)
        {
            this.name = course;
        }
        //return average of scores
        public double average()
        {
            double total = 0.00;
            foreach (var score in scores)
            {
                total += score;
            }
            return (total / scores.Count);
        }
        //return lowest score
        public double lowScore()
        {
            double lowScore = double.MaxValue;
            foreach(var score in scores)
            {
                if(score < lowScore)
                {
                    lowScore = score;
                }
            }
            return lowScore;
        }
        //return highest score
        public double highScore()
        {
            double highScore = double.MinValue;
            foreach(var score in scores)
            {
                if(score > highScore)
                {
                    highScore = score;
                }
            }
            return highScore;
        }
    }
}