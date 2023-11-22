using System;

namespace ConAppAS18
{
    public class Laptop : IConnectable, IRechargeable, IDisplayable
    {

        public string Model { get; set; }
        public int Battery { get; set; }

        public Laptop(string brand)
        {
            Model = Model;
            Battery = 70;
        }
        public bool Connect()
        {
            Console.WriteLine($"{Model}Laptop Connected Successfully");
            return true;
        }

        public void Recharge(int minutes)
        {
            Console.WriteLine($"{Model}Laptop Charged for {minutes} minutes.");
        }

        public string Display()
        {
            return $"{Model}Laptop Information:\nBattery percentage: {Battery} %";
        }
    }
}