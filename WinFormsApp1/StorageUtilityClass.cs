using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    public static class StorageUtilityClass
    {
        const string MainStorageDir = @"C:\temp";
        const string CustStorageDir = @"C:\temp2";
        const string DateStringFormat = "yyyy:MM:dd HH:mm";
        static StorageUtilityClass()
        {
            if (!CheckMainDirectory())
            {
                Directory.CreateDirectory(MainStorageDir);
                Directory.CreateDirectory(CustStorageDir);
            }
        }
        static bool CheckMainDirectory()
        {
            if (Directory.Exists(MainStorageDir) && Directory.Exists(CustStorageDir))
            {
                return true;
            }
            return false;
        }

        public static Account GetLastAccount()
        {
            Account lastAccount = new Account();
            DirectoryInfo directoryInfo = new DirectoryInfo(MainStorageDir);
            FileInfo[] fileInfoArray = directoryInfo.GetFiles();

            if (fileInfoArray.Length == 0)
            {
                return null;
            }
            FileInfo lastFileInfo = fileInfoArray.OrderByDescending(f => f.Length).First();

            string filePath = lastFileInfo.FullName;
            string fileName = Path.GetFileNameWithoutExtension(filePath);

            int accountId = Convert.ToInt32(fileName);
            string customerName;


            using (StreamReader sr = File.OpenText(filePath))
            {
                string headerLine = sr.ReadLine();
                string[] headerParts = headerLine.Split('_');
                customerName = headerParts[1];

                string nextLine;
                DateTime birthDate;
                string phoneNumber;
                string address;

                using (StreamReader srCustomer = File.OpenText(CustStorageDir + "\\" + customerName + ".dat"))
                {
                    nextLine = srCustomer.ReadLine();

                    headerParts = nextLine.Split("_");
                    birthDate = DateTime.ParseExact(headerParts[1],DateStringFormat,null);
                    phoneNumber = headerParts[2];

                    nextLine = srCustomer.ReadLine();
                    address = nextLine;

                    while (!string.IsNullOrEmpty(nextLine))
                    {
                        string addressLine = nextLine;

                        address += "\n" + addressLine;

                        nextLine = srCustomer.ReadLine();
                    }
                }

                lastAccount = new Account(accountId, customerName, birthDate, phoneNumber,address);


                 nextLine = sr.ReadLine();

                while (!string.IsNullOrEmpty(nextLine))
                {
                    string transactionLine = nextLine;
                    nextLine = sr.ReadLine();

                    string[] transactionParts = transactionLine.Split('_');
                    string transactionType = transactionParts[0];

                    double transactionMondey = Convert.ToDouble(transactionParts[1]);
                    DateTime transactionDate = DateTime.ParseExact(transactionParts[2], DateStringFormat, null);
                    string transactionLocation = transactionParts[3];

                    switch (transactionType)
                    {
                        case "Deposit":
                            lastAccount.DepositMoney(transactionMondey, transactionDate,transactionLocation);
                            break;
                        case "Withdraw":
                            lastAccount.WithdrawMoney(transactionMondey, transactionDate, transactionLocation);
                            break;
                    }


                    //lastAccount.AddTransaction(newTransaction);
                }
            }
            //string[] FileAccounts = Directory.GetFiles(MainStorageDir);
            //if (FileAccounts.Length == 0)
            //{
            //    return null;
            //}

            //    string lastAccountFile = FileAccounts[FileAccounts.Length - 1];

            return lastAccount;
        }
        public static bool SaveAccount(Account aAccount)
        {


            using (StreamWriter sm = File.CreateText(MainStorageDir + "\\" + aAccount.AccountNumber + ".dat"))
            {
                sm.WriteLine(aAccount.AccountNumber + "_" + aAccount.CustomerName);

                foreach (Transaction tr in aAccount.ListOfTransactions)
                {
                    string transactionLine = tr.TransactionTypeString + "_" + tr.MoneyAmount + "_" +
                        tr.TransactionDate.ToString(DateStringFormat) + "_" + tr.LocationString;
                    sm.WriteLine(transactionLine);
                }
            }

            FileInfo fileInfoObject = new FileInfo(CustStorageDir + "\\" + aAccount.CustomerName + ".dat");
            using (StreamWriter sm = fileInfoObject.CreateText())
            {
                sm.WriteLine(aAccount.CustomerName + "_" +
                    aAccount.CustomerBirthdate.ToString(DateStringFormat) + "_" +
                    aAccount.CustomerPhone);
                string[] addressLine = aAccount.CustomerAddress.Split(new char[] { '\r', '\n' });

                foreach (string address in addressLine)
                {
                    sm.WriteLine(addressLine);
                }
            }
            return false;
        }
    }
}
