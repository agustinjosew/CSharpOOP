using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckClassLibrary
{
    public sealed class SavingsAccount : Account
    {
        public SavingsAccount() : base()
        {
            Comission = 0.005f;
        }

        public SavingsAccount(int aAccountId ,string aCustomerName ,DateTime aDateOfBirth ,string aPhone = null ,string aAddress = null)
                                : base(aAccountId ,aCustomerName ,aDateOfBirth ,aPhone ,aAddress)
        {
            Comission = 0.005f;
        }

        public override bool DepositMoney(double aAmount)
        {
            
            return base.DepositMoney(aAmount); // returns the base method's result, because we want him tho deposit more money
        }

        public override bool WithdrawMoney(double aAmount)
        {
            double newAmountAfterComission = aAmount + aAmount * Comission; 
            //this is reduced from account, customer gets the wanted amount
            return base.WithdrawMoney(newAmountAfterComission);
        }
    }
}
