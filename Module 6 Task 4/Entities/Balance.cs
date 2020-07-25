using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Module_6_Task_4.Entities
{
    public class Balance
    {
        protected double Val = 0.0d;

        public Balance(double val)
        {
            this.Val = val;
        }

        public double GetBalance()
        {
            return Val;
        }

        public void Add(double amount)
        {
            Val += amount;
        }

        public void Sub(double amount) 
        {
            if(CheckAllowForWithdrawal(amount))
            {
                Val -= amount;
            }
            
        }

        public bool CheckAllowForWithdrawal(double amount)
        {
            return (Val - amount >= 0);
        }
    }
}
