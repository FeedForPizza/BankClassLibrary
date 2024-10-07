using System.Net;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankClassLibrary
{
    public class Account : AccountBase, IAccountValidatetable
    {
        #region Fields and Properties

        //Static fields
        public static double ExchangeRate = 1.1d;
        private const string EMPTY_PHONE = "UNKNOWN";
        private const string EMPTY_ADDRESS = "UNKNOWN";

        Customer _AccountCustomer;

        int _AccountNumber;
        public int AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
        }
        public DateTime CustomerBirthdate
        {
            get { return _AccountCustomer.DateOfBirth; }
        }

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
        public string CustomerPhone
        {
            get
            {
                return _AccountCustomer.PhoneNumber;
            }
            //set
            //{
            //    if (String.IsNullOrEmpty(value))
            //    {
            //        _AccountCustomer.PhoneNumber = EMPTY_PHONE;
            //    }
            //    else
            //    {
            //        _AccountCustomer.PhoneNumber = value;
            //    }

            //}
        }
        public string CustomerAddress
        {
            get
            {
                return _AccountCustomer.Address;
            }
            //set
            //{
            //    if (String.IsNullOrEmpty(value))
            //    {
            //        _AccountCustomer.Address = EMPTY_ADDRESS;
            //    }
            //    else
            //    {
            //        _AccountCustomer.Address = value;
            //    }

            //}
        }
        double _CurrentBalance;
        public override double CurrentBalance
        {
            get
            {
                return CurrentBalance;
            }
            set
            {
                CurrentBalance = value;
            }
        }
        public double CurrentBalanceInForeignCurrency
        {
            get
            {
                return CurrentBalance * ExchangeRate;
            }
        }

        List<Transaction> _ListOfTransactions;
        public List<Transaction> ListOfTransactions
        {
            get { return _ListOfTransactions; }
        }
        public Transaction LastTransaction
        {
            get
            {
                if (ListOfTransactions.Count > 0)
                {
                    return ListOfTransactions[ListOfTransactions.Count - 1];
                }
                else
                {
                    return null;
                }
            }
        }
        private double _Commision;
        public override double Commision
        {
            get
            {
                return _Commision;
            }
            set
            {
                _Commision = value;
            }
        }


        #endregion Fields and Properties

        #region Constructor
        //Default Constructor 
        public Account()
        {
            _AccountCustomer = new Customer("ADMIN", new DateTime(2000, 1, 1), null, null);

            _AccountNumber = Guid.NewGuid().GetHashCode();

            _CurrentBalance = 0;
            _ListOfTransactions = new List<Transaction>();
        }
        //Copy Constructor 
        public Account(Account aAccountToCopy)
        {
            _AccountNumber = aAccountToCopy.AccountNumber;
            _CurrentBalance = aAccountToCopy.CurrentBalance;

            _ListOfTransactions = new List<Transaction>();

            for (int i = 0; i < ListOfTransactions.Count; i++)
            {
                ListOfTransactions.Add(aAccountToCopy.ListOfTransactions[i]);
            }

            _AccountCustomer = new Customer(aAccountToCopy._AccountCustomer);
        }
        //Initialization 
        public Account(string aCustomerName, DateTime aDateOfBirth, string aPhone = null, string aAddress = null)
        {
            _AccountCustomer = new Customer(aCustomerName, aDateOfBirth, aPhone, aAddress);

            _AccountNumber = Guid.NewGuid().GetHashCode();

            _CurrentBalance = 0;
            _ListOfTransactions = new List<Transaction>();
        }
        public Account(int aAccountId,string aCustomerName, DateTime aDateOfBirth, string aPhone = null, string aAddress = null)
        {
            _AccountCustomer = new Customer(aCustomerName, aDateOfBirth, aPhone, aAddress);

            _AccountNumber = aAccountId;

            _CurrentBalance = 0;
            _ListOfTransactions = new List<Transaction>();
        }
        #endregion Constructor

        #region Methods


        //Deposit Money method 
        public override bool DepositMoney(double aAmount)
        {
            bool isSuccess = true;
            _CurrentBalance += aAmount;
            Transaction myTransaction = new Transaction(aAmount, TransactionType.DEPOSIT);
            ListOfTransactions.Add(myTransaction);
            return isSuccess;
        }

        //Withdraw Money method 
        public override bool WithdrawMoney(double aAmount)
        {
            bool isSuccess = true;

            if(_CurrentBalance < aAmount)
            {
                isSuccess = false;
            }
            else
            {
                _CurrentBalance -= aAmount;
                Transaction myTransaction = new Transaction(aAmount, TransactionType.WIDTHDRAW);
                ListOfTransactions.Add(myTransaction);
            }
            
            return isSuccess;
        }

        public virtual void DisplayInfoAccount()
        {
            Console.WriteLine("AccountId: {0} Current Balance {1} Regular Account Type", _AccountNumber, _CurrentBalance);
        }
        protected sealed override void AddTransaction(Transaction newTansaction)
        {
            ListOfTransactions.Add(newTansaction);
            switch (newTansaction.TransactionTypeString)
            {
                case "Deposit":
                    _CurrentBalance += newTansaction.MoneyAmount;
                    break;
                case "Withdraw":
                    _CurrentBalance -= newTansaction.MoneyAmount;
                    break;
            }
        }

        public void DepositMoney(double transactionMondey, DateTime transactionDate, string transactionLocation)
        {
            Transaction newTransaction = new Transaction(transactionMondey,
                "Deposit",
                transactionDate,
                transactionLocation);
            this.AddTransaction(newTransaction);
        }

        public void WithdrawMoney(double transactionMondey, DateTime transactionDate, string transactionLocation)
        {
            Transaction newTransaction = new Transaction(transactionMondey,
                "Withdraw",
                transactionDate,
                transactionLocation);
            this.AddTransaction(newTransaction);
        }

        public bool isCustomerNameValid(string aCustomerName)
        {
            if (!string.IsNullOrEmpty(aCustomerName) && aCustomerName.Length > 2 && aCustomerName.Length < 25)
            {
                return true;
            }
            return false;
        }

        public bool isBirthDateValid(DateTime aBirthDate)
        {
            if (DateTime.Compare(aBirthDate, new DateTime(DateTime.Now.Year - 18, 12, 31)) > 0)
            {

                return false;
            }
            return true;
        }

        public virtual bool isDepositedMoneyRequestValid(double aMoney)
        {
            return true;
        }
        public virtual bool isWithdrawMoneyRequestValid(double aMoney)
        {
            return true;
        }

        #endregion Methods

        #region Nested Types 

        #endregion Nested Types
    }
}
