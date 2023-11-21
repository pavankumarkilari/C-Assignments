using System;

namespace ConAppAS17P02
{
    public class HerbalProduct : Product
    {
        public string herbsUsed;
        public DateTime mfDate;
        public DateTime expDate;

        public void SetHerbalInformation(string herbs, DateTime manufactureDate, DateTime expiryDate)
        {
            herbsUsed = herbs;
            mfDate = manufactureDate;
            expDate = expiryDate;
        }

        public virtual void ShowDetails()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            base.ShowDetails();
            Console.WriteLine($"Herbs Used: {herbsUsed}");
            Console.WriteLine($"Manufacture Date: {mfDate.ToShortDateString()}");
            Console.WriteLine($"Expiry Date: {expDate.ToShortDateString()}");
        }
    }
}
