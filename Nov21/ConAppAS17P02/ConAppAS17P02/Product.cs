using System;


namespace ConAppAS17P02
{
    public class Product
    {
        public int pid;
        public string pname;
        public double pprice;

        public void SetInformation(int id, string name, double price)
        {
            pid = id;
            pname = name;
            pprice = price;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Product ID: {pid}");
            Console.WriteLine($"Product Name: {pname}");
            Console.WriteLine($"Product Price: {pprice:C}");
        }
    }
}
