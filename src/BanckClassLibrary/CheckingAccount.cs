using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckClassLibrary
{
    public sealed class CheckingAccount : Account
    {
        public CheckingAccount() : base()
        {
            Comission = 0.01f;
        }

        public CheckingAccount(int aAccountId ,string aCustomerName ,DateTime aDateOfBirth ,string aPhone = null ,string aAddress = null)
                                :base(aAccountId ,aCustomerName ,aDateOfBirth ,aPhone ,aAddress)
        {
            Comission = 0.01f;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("Checking account balance: {0}, Comission: {1}",CurrentBalance, Comission);
        }

        public override bool DepositMoney(double aAmount)
        {
            double newAmountAfterComission = aAmount - aAmount * Comission;
            return base.DepositMoney(newAmountAfterComission);
        }

        public override bool WithdrawMoney(double aAmount)
        {
            double newAmountAfterComission = aAmount + aAmount * Comission; //this is reduced from account, customer gets the wanted amount
            return base.WithdrawMoney(newAmountAfterComission);
        }
    }
}
