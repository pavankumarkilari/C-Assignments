using System;

namespace ConAppAS17P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HerbalProduct herbalProduct = new HerbalProduct();
            herbalProduct.SetInformation(1, "Herbal Shampoo", 15.99);
            herbalProduct.SetHerbalInformation("Aloe Vera, Lavender", new DateTime(2023, 1, 1), new DateTime(2024, 12, 31));

            Console.WriteLine("Product Details:");
            herbalProduct.ShowDetails();

            Console.ReadKey();
        }
    }
}
