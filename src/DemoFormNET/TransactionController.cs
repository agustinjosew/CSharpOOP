using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanckClassLibrary;

namespace DemoFormNET
{
    public class TransactionController
    {
        private Transaction model;

        public TransactionController(Transaction aTransaction)
        {
            model = aTransaction;
        }

        public void DisplayTransaction()
        {
            //Console.WriteLine((TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw") + "is done.");
            //Console.WriteLine("Total amount: " + _MoneyAmount + "Date: " + _TransactionDate.ToString("yyyy/MM/dd"));
            Console.WriteLine(model.TransactionTypeString + "is done.");
            Console.WriteLine("Total amount: " + model.MoneyAmount + "Date: " + model.DateString);
        }
    }
}
