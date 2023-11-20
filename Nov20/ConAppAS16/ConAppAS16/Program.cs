using System;
using System.Diagnostics;


namespace ConAppQuickSort
{
    internal class Program
    {
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }
        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, right);
            return i + 1;
        }
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        public static void CheckQuickSort(int[] arr)
        {
            int flag = 1;
            for (int i = 0; i < arr.Length -1; i++)
            {
                    if (arr[i] > arr[i+1])
                    {
                        flag = 0;
                    }
            }
            string SortedOrNot = (flag == 1) ? "Given array is sorted in ascending order" : "Given array is not sorted.";
            Console.WriteLine(SortedOrNot);
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] array = { 9, -3, 5, 2, 6, 8, -6, 1, 3, 10 };
            Console.WriteLine("Original array");
            Print(array);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QuickSort(array);
            stopwatch.Stop();
            Console.WriteLine("After Quick sort");
            Print(array);
            Console.WriteLine($"Time taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            CheckQuickSort(array);
            Console.ReadKey();
        }
    }
}
