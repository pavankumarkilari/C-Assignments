using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAS17
{
    public class BankAccount
    {
        int PresentNumberOfAccountsInBank = 12034;
        readonly int AccountNumber;
        string HolderName;
        int AccountBalance;
        public BankAccount(string Holdername)
        {
            AccountNumber = ++PresentNumberOfAccountsInBank;
            HolderName = Holdername;
            AccountBalance = 0;
        }
        public void Deposit(int DepositAmount)
        {
            if (DepositAmount > 0) 
            {
                AccountBalance += DepositAmount;
                Console.WriteLine($"Account balance after depositing the amount: {AccountBalance}");
            }
            else
            {
                Console.WriteLine("Amount should be greater than 0.");
            }
        }
        public void Withdraw(int WithdrawAmount)
        {
            if (WithdrawAmount>0 && WithdrawAmount<=AccountBalance)
            {
                AccountBalance -= WithdrawAmount;
                Console.WriteLine($"Account balance after withdrawing the amount: {AccountBalance}");
            }
            else
            {
                Console.WriteLine($"Amount should be greater than 0 and less than {AccountBalance}.");
            }
        }
        public int AccNumber { get { return AccountNumber; } }
        public string Name { get{ return HolderName; } set { HolderName = value; } }
    }
}
