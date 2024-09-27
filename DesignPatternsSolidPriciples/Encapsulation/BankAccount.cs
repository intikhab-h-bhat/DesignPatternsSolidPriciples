using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSolidPriciples.Encapsulation
{
    public class BankAccount
    {

        private decimal _balance;

        public BankAccount(decimal balance)
        {
            Deposit(balance);
            
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount should be positive");
            }
               
            this._balance += amount;
        }

        public decimal WithDraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("withdrawl amount should be grater than 0");
            }
            if (amount > _balance) {
                
                throw new ArgumentException("not much available fund");
            }
            return this._balance -= amount;

        }
    }
}
