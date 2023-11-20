using System;

namespace ConAppAs15
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            int noSwap = 0;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                        noSwap++;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static int BinarySearch(int[] arr, int sItem)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == sItem)
                {
                    return mid;
                }
                else if (arr[mid] < sItem)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;

        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i <arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public static void DescendingOrder(int[] arr)
        {
            for (int i = (arr.Length-1); i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 15, 2, 5, 10, 6 };
            Console.WriteLine("Print array without sort");
            Print(arr);
            BubbleSort(arr);
            Console.WriteLine("After bubbble sort(in descending order)");
            DescendingOrder(arr);
            Console.ReadKey();
        }
    }
}
