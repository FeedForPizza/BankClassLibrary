using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankClassLibrary.Account;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoForm
{
    public partial class DisplayAccountForm : Form
    {
        private BankClassLibrary.Account myAccount;
        private BankClassLibrary.Transaction transaction;
        BindingList<Transaction> data;
        //constructor
        private DisplayAccountForm()
        {

        }
        public DisplayAccountForm(Account aAccount)
        {
            InitializeComponent();
            myAccount = aAccount;
            data = new BindingList<Transaction>(myAccount.ListOfTransactions);
            TransactionListBox.DataSource = data;
            TransactionListBox.DisplayMember = "Summary";
            CustomerNamePanel.TextInput = myAccount.CustomerName;
            CurrentBalancePanel.TextInput = myAccount.CurrentBalance.ToString();
        }

        private void TransactionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newIndex = TransactionListBox.SelectedIndex;

            Transaction selectedTransaction = myAccount.ListOfTransactions[newIndex];
            
            TransactionTypePanel.TextInput = selectedTransaction.TransactionTypeString;
            TransactionDatePanel.TextInput = selectedTransaction.DateString;
            TransactionAmountPanel.TextInput = selectedTransaction.MoneyAmount.ToString();
            TransactionLocationPanel.TextInput = selectedTransaction.LocationString;
            
        }
        

        private void depositButton_Click(object sender, EventArgs e)
        {
            string amountOfTransaction = depositAmountTextBox.Text.ToString();
            double amount = Convert.ToDouble(amountOfTransaction);
            if (!myAccount.DepositMoney(amount))
            {
                MessageBox.Show("Request is not valid");
                return;
            }
            
            
            CurrentBalancePanel.TextInput = myAccount.CurrentBalance.ToString();
            data.ResetBindings();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            string amountOfTransaction = withdrawAmountTextBox.Text;
            double amount = Convert.ToDouble(amountOfTransaction);
            if (!myAccount.WithdrawMoney(amount))
            {
                MessageBox.Show("Request is not valid");
                return;
            }
            CurrentBalancePanel.TextInput = myAccount.CurrentBalance.ToString();
            data.ResetBindings();
        }

        
    }
}
