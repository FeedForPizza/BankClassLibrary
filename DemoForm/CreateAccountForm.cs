using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankClassLibrary;

namespace DemoForm
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            
        }

        private void PhoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PhoneMaskedTextBox.Enabled = PhoneCheckBox.Checked;
        }

        private void AddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AddressRichTextBox.Enabled = AddressCheckBox.Checked;
        }
    }
}
