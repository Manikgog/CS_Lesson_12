using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_12
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public double Balance { get; set; }

        public Account(int accountNumber, string ownerName, double balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }

        public void Deposit(double money)
        {
            Balance += money;
        }

        public void Withdraw(double money)
        {
            Balance -= money;
        }

        public override string ToString()
        {
            return "Владелец счёта: " + OwnerName +
                ", номер счёта: " + AccountNumber +
                ", баланс: " + Balance;
        }

        public void PrintAccountInfo()
        {
            Console.WriteLine(this);
        }
    }
}
