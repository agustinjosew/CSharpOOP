using System;
using System.Collections.Generic;


namespace BanckClassLibrary
{
    public class Account : AccountBase
    {
        #region     FIELDS AND PROPERTIES
        public  static double ExchangeRate  = 1.1d;                    // exchange rate to foreign currency
        private const  string EMPTY_ADDRESS   = "UNKNOWN";
        private const  string EMPTY_PHONE     = "#####";

        int             _AccountNumber;
        public int AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
        }

        Customer        _AccountCustomer;        

        public override string CustomerName
        {
            get
            {
                return _AccountCustomer.CustomerName;
            }
            set
            {
                _AccountCustomer.CustomerName = value;
            }
        }    

        public DateTime CustomerBirthDate
        {
            get
            {
                return _AccountCustomer.DateOfBirth;
            }
        }
        
        public string CustomerPhone
        {
            get
            {
                return _AccountCustomer.PhoneNumber;
            }

            //set
            //{
            //    if(string.IsNullOrEmpty(value))
            //    {
            //        _AccountCustomer.PhoneNumber = EMPTY_PHONE;
            //    }
            //    else
            //    {
            //        _AccountCustomer.PhoneNumber = value;
            //    }
                
            }        

        public string CustomerAddress
        {
            get
            {
                return _AccountCustomer.Address;
            }
            //set
            //{
            //    if(string.IsNullOrEmpty(value))
            //    {
            //        _AccountCustomer.Address = EMPTY_ADDRESS;
                    
            //    }
            //    else
            //    {
            //        _AccountCustomer.Address = value;
            //    }
                
            }
        

        double   _CurrentBalance;
        public override double CurrentBalance
        {
            get
            {
                return _CurrentBalance;
            }
        }        

        public double CurrentBalanceInForeignCurrency
        {
            get
            {
                return _CurrentBalance * ExchangeRate;
            }
        }

        List<Transaction> _ListOfTransactions;      
        public List<Transaction> ListOfTransactions
        {
            get
            {
                return _ListOfTransactions;
            }
        }

        public Transaction LastTransaction
        {
            get
            {
                if(_ListOfTransactions.Count > 0)
                {
                    //return ListOfTransactions[ListOfTransactions.Count - 1];
                    return _ListOfTransactions[^1];                    
                }
                else
                {
                    return null;
                }
            }
        }

        private double _Comission;
        public override double Comission
        {
            get
            {
                return _Comission;
            }
            set
            {
                _Comission = value;
            }
        }
        #endregion FIELDS AND PROPERTIES

        #region CONSTRUCTORS
        //Default constructor
        public Account()
        {
            _AccountCustomer    = new Customer("Admin" ,new DateTime(1995,1,1) ,null ,null);
            _AccountNumber      = Guid.NewGuid().GetHashCode();
            _CurrentBalance     = 0;
            _ListOfTransactions = new List<Transaction>();
        }

        //Copy constructor Account
        public Account (Account aAccountToCopy)
        {
            _AccountNumber      = aAccountToCopy._AccountNumber;
            _CurrentBalance     = aAccountToCopy._CurrentBalance;
            _ListOfTransactions = new List<Transaction>();

            for(int i= 0; i < aAccountToCopy._ListOfTransactions.Count; i++)
            {
                _ListOfTransactions.Add(aAccountToCopy._ListOfTransactions[i]);
            }
            //Copy Customer
            _AccountCustomer = new Customer(aAccountToCopy._AccountCustomer);
        }

        public Account(string aCustomerName ,DateTime aDateOfBirth ,string aPhone = null ,string aAddress = null)
        {
            _AccountCustomer    = new Customer(aCustomerName ,aDateOfBirth ,aPhone ,aAddress);
            _AccountNumber      = Guid.NewGuid().GetHashCode();
            _CurrentBalance     = 0;
            _ListOfTransactions = new List<Transaction>();
        }

        public Account(int aAccountId ,string aCustomerName ,DateTime aDateOfBirth ,string aPhone = null ,string aAddress = null)
        {
            _AccountCustomer    = new Customer(aCustomerName ,aDateOfBirth ,aPhone ,aAddress);
            _AccountNumber      = aAccountId;
            _CurrentBalance     = 0;
            _ListOfTransactions = new List<Transaction>();
        }
        #endregion CONSTRUCTORS

        #region METHODS
        //Display summary info on the console
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine("Acount Id: {0} Current Balance: {1} Regular Account Type", _AccountNumber, _CurrentBalance);
        }

        public override bool DepositMoney(double aAmount)
        {
            bool isSuccess = false;
            _CurrentBalance += aAmount;
            Transaction myTransaction = new Transaction (aAmount, TransactionType.DEPOSIT);
            _ListOfTransactions.Add(myTransaction);
            return isSuccess;
        }

        public override bool WithdrawMoney(double aAmount)
        {
            bool isSuccess = false;
            _CurrentBalance -= aAmount;
            Transaction myTransaction = new Transaction(aAmount , TransactionType.WITDRAWAL);
            _ListOfTransactions.Add(myTransaction);
            return isSuccess;
        }

        protected sealed override void AddTransaction(Transaction newTransaction)
        {
            ListOfTransactions.Add(newTransaction);

            switch(newTransaction.TransactionTypeString)
            {
                case "Deposit":
                    _CurrentBalance += newTransaction.MoneyAmount;
                    break;
                case "Withdraw":
                    _CurrentBalance -= newTransaction.MoneyAmount;
                    break;
            }
        }

        public void DepositMoney(double transactionAmount ,DateTime transactionDate ,string transactionLocation)
        {
           Transaction newTransaction   = new Transaction(transactionAmount, "Deposit", transactionDate, transactionLocation);
            this.AddTransaction(newTransaction);
        }

        public void WithdrawMoney(double transactionAmount ,DateTime transactionDate ,string transactionLocation)
        {
            Transaction newTransaction = new Transaction(transactionAmount, "Withdraw", transactionDate, transactionLocation);
            this.AddTransaction(newTransaction);
        }
        #endregion METHODS

        #region NESTED TYPES

        #endregion NESTED TYPES

    }
}
