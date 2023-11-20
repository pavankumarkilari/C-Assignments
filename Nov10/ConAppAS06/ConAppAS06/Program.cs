using System;
using System.Collections;

namespace ASDate10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // part 1
            // task 1
            //int[][] matrix = new int[3][];
            //matrix[0] = new int[] { 2, 8, 4, 6 };
            //matrix[1] = new int[] { 1, 5 };
            //matrix[2] = new int[] { 9, 2, 7 };

            //// task 2
            //int element = matrix[0][1];
            //foreach (var row in matrix)
            //{
            //   Console.WriteLine(string.Join(", ",row));
            //}

            // task 3

            // task 4
            //object[][] objectMatrix = new object[2][];
            //objectMatrix[0] = new object[] { 3, "White", 2.14 };
            //objectMatrix[1] = new object[] {true, 'c', DateTime.Now };

            //foreach (var row in objectMatrix)
            //{
            //    foreach (var col in row)
            //    {
            //        Console.WriteLine($"{col} ({col.GetType().Name})");
            //    }
            //}

            // part 2
            // task 1
            ArrayList studentGrades = new ArrayList();
            studentGrades.AddRange(new int[] { 85, 92, 78, 95, 88 });

            // task 2
            foreach (var item in studentGrades)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine($"\nSum  of all the grades = {studentGrades.OfType<int>().Sum()}");
            int sum = 0;
            foreach (int item in studentGrades)
            {
                sum += item;
            }
            Console.WriteLine($"\nSum of all the grades = {sum}");

            // task 3
            studentGrades.Add(90);
            foreach (var item in studentGrades)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            // task 4
            studentGrades.Remove(78);
            foreach (var item in studentGrades)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            // task 5
            int index = studentGrades.IndexOf(95);
            //studentGrades.RemoveAt(index);
            //studentGrades.Insert(index, 96);
            studentGrades[index] = 96;
            foreach (var item in studentGrades)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
    }
}
