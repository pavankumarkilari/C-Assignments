using System;

namespace BasicCSharpAssignment
{
    public class Arrays
    {
        public void SumAverage()
        {
            // int[] array = { 8, 3, 2, 12, 1 };
            int[] array = new int[5];
            array[0] = 8;
            array[1] = 2;
            array[2] = 3;
            array[3] = 12;
            array[4] = 1;
            int Sum = 0;
            foreach (int num in array)
            {
                Sum += num;
            }
            Console.WriteLine($"Sum of elements in the array: {Sum}");
            Console.WriteLine($"Average of elements in the array: {Sum / array.Length}");

        }
    }
}
