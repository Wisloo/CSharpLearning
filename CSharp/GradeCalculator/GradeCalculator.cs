namespace GradeCalculator;
using System;
using System.Collections.Generic;
public class GradeCalculator
{
    public static void Main(string[] args)
    {
        int subjectCount;
        List <double> scores = new List<double>();
        Console.WriteLine("How many tests in a subject? ");
        subjectCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < subjectCount + 1; i++)
        {
            Console.WriteLine($"Enter score for test {i}: ");
            double scoresInTest = double.Parse(Console.ReadLine()); // use parse when dealing with lists in user input
            scores.Add(scoresInTest);
        }
        
        double average = CalculateAverage(scores); // think of parameters as telephones who communicate with functions
        char grade = GetLetterGrade(average); // you pass the double average to the GetLetterGrade function

        Console.WriteLine($"Your average is: {average}");
        Console.WriteLine($"Your grade is: {grade}");
    }

    public static double CalculateAverage(List<double> scores) // since you are passing on a list, then you need a list datatype
    {
        double sum = 0;
        double average = 0;
        foreach (double score in scores)
        {
            sum += score;
        }
        average = sum / scores.Count; // Count is for identifying how many items are on the list
        return average;
    }

    public static char GetLetterGrade(double average)
    {
        if (average >= 90)
        {
            return 'A';
        } else if (average >= 80)
        {
            return 'B';
        } else if (average >= 70)
        {
            return 'C';
        } else if (average >= 60)
        {
            return 'D';
        }
        else
        {
            return 'F';
        }
    }
}