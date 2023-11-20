using System;

namespace ConAppAS10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[3][];
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };
            int studentNumber = 1, totalStudentsSum = 0, scoreCount = 0;

            // printing each student scores
            foreach (var student in studentScores)
            {
                int eachStudentSum = 0;
                Console.Write($"Student {studentNumber}:");
                foreach (var score in student)
                {
                    Console.Write($" {score}");
                    eachStudentSum += score;
                    scoreCount += 1;
                }
                totalStudentsSum += eachStudentSum;
                // calculating the average of each student
                int eachStudentAverage = eachStudentSum / studentScores[studentNumber - 1].Length;
                Console.WriteLine($"\nAverage of student {studentNumber}: {eachStudentAverage}\n");
                studentNumber++;
            }
            // calculating the average of total students

            int totalStudentAverage = totalStudentsSum / scoreCount;
            Console.WriteLine($"\nAverage of all students: {totalStudentAverage}");



        }
    }
}
