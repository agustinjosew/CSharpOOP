using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckClassLibrary
{
    interface IAccountValidatable
    {
        bool IscustomerNameValid(string aCustomerName);

        bool IsBirthDateValid(DateTime aBirthdate);

        bool IsDepositMoneyRequestValid(double aMoneyAmount);

        bool IsWithdrawMoneyRequestValid(double aMoneyAmount);

    }
}
