using System;
using System.Collections.Generic;

namespace BanckClassLibrary
{
    public class Account
    {
        #region     FIELDS AND PROPERTIES
        public  static double ExchangeRate  = 1.1d;                    // exchange rate to foreign currency
        private const  string EMPTY_ADDRESS   = "UNKNOWN";
        private const  string EMPTY_PHONE     = "#####";

        int             AccountNumber;

        Customer        AccountCustomer;
        public string CustomerName
        {
            get
            {
                return AccountCustomer.CustomerName;
            }
        }    
        
        public string CustomerPhone
        {
            get
            {
                return AccountCustomer.PhoneNumber;
            }

            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    AccountCustomer.PhoneNumber = EMPTY_PHONE;
                }
                else
                {
                    AccountCustomer.PhoneNumber = value;
                }
                
            }
        }

        public string CustomerAddress
        {
            get
            {
                return AccountCustomer.Address;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    AccountCustomer.Address = EMPTY_ADDRESS;
                }
                else
                {
                    AccountCustomer.Address = value;
                }
                
            }
        }

        double   CurrentBalance;
        public double Balance
        {
            get
            {
                return CurrentBalance;
            }
        }

        public double BalanceInForeignCurrency
        {
            get
            {
                return CurrentBalance * ExchangeRate;
            }
        }


        List<Transaction> ListOfTransactions;      
        public List<Transaction> TransactionList
        {
            get
            {
                return ListOfTransactions;
            }
        }

        public Transaction LastTransaction
        {
            get
            {
                if(ListOfTransactions.Count > 0)
                {
                    //return ListOfTransactions[ListOfTransactions.Count - 1];
                    return ListOfTransactions[^1];                    
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion FIELDS AND PROPERTIES

        #region CONSTRUCTORS
        //Default constructor
        public Account()
        {
            AccountCustomer    = new Customer("Admin" ,new DateTime(1995,1,1) ,null ,null);
            AccountNumber      = Guid.NewGuid().GetHashCode();
            CurrentBalance     = 0;
            ListOfTransactions = new List<Transaction>();
        }

        //Copy constructor Account
        public Account (Account aAccountToCopy)
        {
            AccountNumber      = aAccountToCopy.AccountNumber;
            CurrentBalance     = aAccountToCopy.CurrentBalance;
            ListOfTransactions = new List<Transaction>();
            for(int i          = 0; i < aAccountToCopy.ListOfTransactions.Count; i++)
            {
                ListOfTransactions.Add(aAccountToCopy.ListOfTransactions[i]);
            }
            //Copy Customer
            AccountCustomer = new Customer(aAccountToCopy.AccountCustomer);
        }

        public Account(string aCustomerName ,DateTime aDateOfBirth ,string aPhone = null ,string aAddress = null)
        {
            AccountCustomer    = new Customer(aCustomerName ,aDateOfBirth ,aPhone ,aAddress);
            AccountNumber      = Guid.NewGuid().GetHashCode();
            CurrentBalance     = 0;
            ListOfTransactions = new List<Transaction>();
        }
        #endregion CONSTRUCTORS

        //metodo mostrar balance
        void DisplayBalance()
        {

        }

        public bool DepositMoney(double aAmount)
        {
            bool isSuccess = false;
            CurrentBalance += aAmount;
            Transaction myTransaction = new Transaction (aAmount, TransactionType.DEPOSIT);
            ListOfTransactions.Add(myTransaction);
            return isSuccess;
        }


        public bool WithdrawMoney(double aAmount)
        {
            bool isSuccess = false;
            CurrentBalance -= aAmount;
            Transaction myTransaction = new Transaction(aAmount , TransactionType.WITDRAWAL);
            ListOfTransactions.Add(myTransaction);
            return isSuccess;
        }

        public class Transaction
        {
            double   AmountOfTransaction;
            DateTime TransactionDate;
            string   Location;
            //Transaction type
            TransactionType TypeOfTransaction;

           

            public void DisplayTransaction()
            {
                Console.WriteLine((TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw")+ "is done.");
                Console.WriteLine("Total amount: " + AmountOfTransaction + "Date: " + TransactionDate.ToString("yyyy/MM/dd"));
            }

            //we do not want default transactions
            private Transaction() 
            {
                //cannot be called
            }

            //Regular constructor
            public Transaction(double aAmountOfTransaction, TransactionType aTransactionType)
            {
                AmountOfTransaction = aAmountOfTransaction;
                TypeOfTransaction   = aTransactionType;
                TransactionDate     = DateTime.Now;
                Location            = "Earth";
            }

            //Copy of regular constructor
            public Transaction(Transaction aTransactionCopy)
            {
                AmountOfTransaction = aTransactionCopy.AmountOfTransaction;
                TypeOfTransaction   = aTransactionCopy.TypeOfTransaction;
                TransactionDate     = aTransactionCopy.TransactionDate;
                Location            = aTransactionCopy.Location;
            }

            public string Summary
            {
                get
                {
                    return   TranscationTypeString +" " + MoneyAmount + " " + DateString + " " + LocationString;
                }
            }

            public string TranscationTypeString
            {
                get
                {
                    return (TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw");
                }
            }

            public double MoneyAmount
            {
                get
                {
                    return AmountOfTransaction;
                }
                set
                {
                    AmountOfTransaction = value;
                }
            }

            public string DateString
            {
                get
                {
                    return (TransactionDate.ToString("yyyy/MM/dd hh:mm:dd"));
                }
            }

            public string LocationString
            {
                get
                {
                    return Location;
                }
            }

        }

        public enum TransactionType
        {
            DEPOSIT,
            WITDRAWAL,
        }


    }
}
