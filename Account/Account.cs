using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AccountDiagram
    {
        class Account
        {
            #region Fields
            private double annualInterestRate;

            private decimal balance;
            private DateTime dateCreated;
            private long id;
            #endregion

            #region Constructors
            public Account()
            {
                Balance = 0;
                DateCreated = DateTime.Now;
                Id = 0; ;
                AnnualInterestRate = 0.1;
            }
            public Account(decimal balance,
             DateTime dateCreated,
             long id,
             double interestAnnualRate)
            {
                Balance = balance;
                DateCreated = dateCreated;
                Id = id;
                AnnualInterestRate = interestAnnualRate;
            }


            public Account(Account account)
            {
                Balance = account.balance;
                DateCreated = account.dateCreated;
                Id = account.id;
                AnnualInterestRate = account.annualInterestRate;
            }
            #endregion

            #region Properties
            public decimal Balance
            {
                get { return balance; }
                set { balance = value > 0 ? value : 1; }
            }


            public long Id
            {
                get { return id; }
                set { id = value > 0 ? value : 1; }
            }
            public double AnnualInterestRate
            {
                get => default;
                set { annualInterestRate = value > 0 ? value : 0.01; }
            }
            public DateTime DateCreated
            {
                get { return dateCreated; }
                set { dateCreated = value != null ? value : DateTime.Now; }
            }
            #endregion

            #region Metods
            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                }
                else
                {
                    Console.WriteLine("Deposit: Error.Cannot deposit negative amounts");
                }
            }
            public void Withdraw(decimal amount)
            {

                if (amount > 0 && (balance - amount) > 0)
                {
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine("Withdraw: Error.Wrong amount to withdraw.");
                }
            }

            #endregion
            public override string ToString()
            {
                return string.Format($"Account: Balance: {balance}\n" +
                $"DateCreated: {dateCreated}\n" +
                $"Interest rate: {annualInterestRate}");
            }
        }
    }
}
