using System;


namespace ConAppAS18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Samsung");
            Laptop laptop = new Laptop("Lenovo");
            smartphone.Connect();
            smartphone.Recharge(70);
            Console.WriteLine(smartphone.Display());

            Console.WriteLine("_________\n");


            laptop.Connect();
            laptop.Recharge(90);
            Console.WriteLine(laptop.Display());
            Console.ReadKey();
        }
    }
}