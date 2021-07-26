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

        }

        public CheckingAccount(int aAccountId ,string aCustomerName ,DateTime aDateOfBirth ,string aPhone = null ,string aAddress = null)
                                :base(aAccountId ,aCustomerName ,aDateOfBirth ,aPhone ,aAddress)
        {

        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("Checking account balance: {0}, Comission: {1}",CurrentBalance, Comission);
        }

        public override bool DepositMoney(double aAmount)
        {
            return base.DepositMoney(aAmount);
        }

        public override bool WithdrawMoney(double aAmount)
        {
            return base.WithdrawMoney(aAmount);
        }
    }
}
