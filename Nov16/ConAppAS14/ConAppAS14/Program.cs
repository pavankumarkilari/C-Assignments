using System;

namespace ConAppAS14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var largeData = new LargeDataCollection(new object[] { 1, "Hello", 3.14 }))
            {
                // Demonstrate adding, removing, and accessing elements
                largeData.AddElement("New Element");
                Console.WriteLine(largeData.AccessElement(0));

                largeData.RemoveElement(3.14);

                try
                {
                    Console.WriteLine(largeData.AccessElement(2)); // This will throw an exception
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            } // Dispose will be called implicitly when leaving the using block
        }
    }
}
