using System;

namespace ConAppAS18
{
    public class Smartphone : IConnectable, IRechargeable, IDisplayable
    {

        public string Brand { get; set; }
        public int Battery { get; set; }

        public Smartphone(string model)
        {
            Brand = Brand;
            Battery = 92;
        }
        public bool Connect()
        {
            Console.WriteLine($"{Brand}Smartphone Connected Successfully");
            return true;
        }

        public void Recharge(int minutes)
        {
            Console.WriteLine($"{Brand}Smartphone charged for {minutes} minutes.");
        }

        public string Display()
        {
            return $"{Brand}Smartphone Information:\nBattery percentage:{Battery} %";
        }
    }
}