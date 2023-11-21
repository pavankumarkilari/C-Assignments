using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAS17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Japan");
            Console.WriteLine("Account Number:" + bankAccount.AccNumber);
            Console.WriteLine("Account holder name: " + bankAccount.Name);
            bankAccount.Deposit(412345);
            bankAccount.Withdraw(5000);
        }
    }
}
