using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckClassLibrary
{
    public class CheckingAccount : Account
    {
        public CheckingAccount() : base()
        {

        }

        public CheckingAccount(int aAccountId ,string aCustomerName ,DateTime aDateOfBirth ,string aPhone = null ,string aAddress = null)
                                :base(aAccountId ,aCustomerName ,aDateOfBirth ,aPhone ,aAddress)
        {

        }
    }
}
