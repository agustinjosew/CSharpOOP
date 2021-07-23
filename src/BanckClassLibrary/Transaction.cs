using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckClassLibrary
{
    public class Transaction
    {
        #region FIELDS AND PROPERTIES
        double   _MoneyAmount;
        DateTime _TransactionDate;
        string   _Location;

        //Transaction type
        TransactionType _TypeOfTransaction;        

        //we do not want default transactions
        private Transaction()
        {
            //cannot be called
        }

        //Regular constructor
        public Transaction(double aAmountOfTransaction ,TransactionType aTransactionType)
        {
            _MoneyAmount      = aAmountOfTransaction;
            _TypeOfTransaction = aTransactionType;
            _TransactionDate  = DateTime.Now;
            _Location         = "Earth";
        }

        public Transaction(double aAmountOfTransaction, string aTransactionString, DateTime aTransactionDate, string aTransactionLocation)
        {
            _MoneyAmount     = aAmountOfTransaction;
            _TransactionDate = aTransactionDate;
            _Location        = aTransactionLocation;

            switch(aTransactionString)
            {
                case "Deposit":
                    _TypeOfTransaction = TransactionType.DEPOSIT;
                    break;
                case "Withdraw":
                    _TypeOfTransaction = TransactionType.WITDRAWAL;
                    break;
            }



        }

      

        //Copy of regular constructor
        public Transaction(Transaction aTransactionCopy)
        {
            _MoneyAmount      = aTransactionCopy._MoneyAmount;
            _TypeOfTransaction = aTransactionCopy._TypeOfTransaction;
            _TransactionDate  = aTransactionCopy._TransactionDate;
            _Location         = aTransactionCopy._Location;
        }

        public string Summary
        {
            get
            {
                return TransactionTypeString + " " + MoneyAmount + " " + DateString + " " + LocationString;
            }
        }

        public string TransactionTypeString
        {
            get
            {
                return (_TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw");
            }
        }

        public double MoneyAmount
        {
            get
            {
                return _MoneyAmount;
            }
            set
            {
                _MoneyAmount = value;
            }
        }

        public string DateString
        {
            get
            {
                return (_TransactionDate.ToString("yyyy/MM/dd hh:mm:dd"));
            }
        }

        public string LocationString
        {
            get
            {
                return _Location;
            }
        }

        public DateTime TransactionDate
        {
            get
            {
                return _TransactionDate;
            }
        }

        #endregion FIELDS AND PROPERTIES
    }
    public enum TransactionType
    {
        DEPOSIT,
        WITDRAWAL,
    }
}
