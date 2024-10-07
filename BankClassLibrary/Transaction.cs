using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    public class Transaction
    {
        #region Fields and Properties
        double _MoneyAmount;
        DateTime _TransactionDate;
        string _Location;
        public TransactionType _TypeOfTransaction;

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
        public string Summary
        {
            get
            {
                return TransactionTypeString + " " + MoneyAmount + " " + DateString;
            }
        }

        public string TransactionTypeString
        {
            get
            {
                return (_TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw");
            }
        }

        public string LocationString
        {
            get
            {
                return _Location;
            }
        }

        public string DateString
        {
            get
            {
                return _TransactionDate.ToString("yyyy-MM-dd hh:mm");
            }
        }

        public DateTime TransactionDate
        {
            get
            {
                return _TransactionDate;
            }
        }

        #endregion Fields and Properties

        #region Constructor
        //Regular Constructor
        public Transaction(double aAmountOfTransaction, TransactionType aTransactionType)
        {
            _MoneyAmount = aAmountOfTransaction;
            _TypeOfTransaction = aTransactionType;

            _TransactionDate = DateTime.Now;
            _Location = "Earth";
        }
        public Transaction(double aAmountOfTransaction, string aTransactionTypeString,
            DateTime aTransactionDate, string aTransactionLocation)
        {
            _MoneyAmount = aAmountOfTransaction;
            _TransactionDate = aTransactionDate;
            _Location = aTransactionLocation;
            switch (aTransactionTypeString)
            {
                case "Deposit": 
                    _TypeOfTransaction = TransactionType.DEPOSIT;
                    break;
                case "Withdraw":
                    _TypeOfTransaction = TransactionType.WIDTHDRAW;
                    break;
            }


        }

        //Default Constructor
        private Transaction() { }

        //Copy Constructor 
        public Transaction(Transaction aTransaction)
        {
            _MoneyAmount = aTransaction._MoneyAmount;
            _TypeOfTransaction = aTransaction._TypeOfTransaction;
            _TransactionDate = aTransaction._TransactionDate;
            _Location = aTransaction._Location;

        }

        #endregion Constructor

        #region Methods

        #endregion Methods
    }
    public enum TransactionType
    {
        DEPOSIT,
        WIDTHDRAW
    }
}
