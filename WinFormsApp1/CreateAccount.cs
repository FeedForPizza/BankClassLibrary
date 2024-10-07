using BankClassLibrary;
using DemoForm;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CreateAccount : Form
    {
        private string PhoneTextInput
        {
            get
            {
                if (PhoneMaskedTextBox.Enabled)
                {
                    return PhoneMaskedTextBox.Text;
                }
                else
                {
                    return null;
                }
            }
        }
        private string AddressTextInput
        {
            get
            {
                if (AddressRichTextBox.Enabled)
                {
                    return AddressRichTextBox.Text;
                }
                else
                {
                    return null;
                }
            }
        }
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void PhoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PhoneMaskedTextBox.Enabled = PhoneCheckBox.Checked;
        }

        private void AddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AddressRichTextBox.Enabled = AddressCheckBox.Checked;
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string customerName = CustomerNameTextBox.Text;
            DateTime birthDate = BirthdateDateTimePicker.Value;

            //Validations 
            if (!ValidateCustomerName(customerName))
            {
                MessageBox.Show("Customer Name is invalid");
                return;
            }
            else if (!ValidateBirthdate(birthDate))
            {
                MessageBox.Show("Birthdate is invalid");
                return;
            }
            string phone = PhoneTextInput;
            string address = AddressTextInput;
            //Account newAccount = new Account(customerName, birthDate, phone, address);

            CheckingAccount newChekingAccount = new CheckingAccount(-1, customerName, birthDate, phone, address);
            SavingsAccount newSavingsAccount = new SavingsAccount(-1, customerName, birthDate, phone, address);

            //newAccount.DepositMoney(1000);
            //newAccount.WithdrawMoney(500);

            //newAccount.DisplayInfoAccount();
            //newChekingAccount.DisplayInfoAccount();


            //newCheckingAccount.
            //StorageUtilityClass.SaveAccount(newAccount);

            //Account lastAccount = StorageUtilityClass.GetLastAccount();
            //MessageBox.Show("Account of customer " + customerName + " has been created");

            DisplayAccountForm displayAccount1 = new DisplayAccountForm(newChekingAccount);
            DisplayAccountForm displayAccount2 = new DisplayAccountForm(newSavingsAccount);

            displayAccount1.Text = "Checking Account";
            displayAccount2.Text = "Savings Account";
            this.Hide();
            displayAccount1.ShowDialog();
            displayAccount2.ShowDialog();
            this.Show();
        }
        private bool ValidateCustomerName(string aTextToValidate)
        {
            if (!string.IsNullOrEmpty(aTextToValidate) && aTextToValidate.Length > 2 && aTextToValidate.Length < 25)
            {
                return true;
            }
            return false;
        }
        private bool ValidateBirthdate(DateTime date)
        {
            if (DateTime.Compare(date, new DateTime(DateTime.Now.Year - 18, 12, 31)) > 0)
            {

                return false;
            }
            return true;
        }
    }
}

