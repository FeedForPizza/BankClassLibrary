namespace DemoForm
{
    partial class CreateAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AddressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.PhoneCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CustomerNameTextbox
            // 
            this.CustomerNameTextbox.Location = new System.Drawing.Point(192, 13);
            this.CustomerNameTextbox.Name = "CustomerNameTextbox";
            this.CustomerNameTextbox.Size = new System.Drawing.Size(200, 22);
            this.CustomerNameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(192, 61);
            this.BirthDatePicker.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.BirthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(200, 22);
            this.BirthDatePicker.TabIndex = 2;
            this.BirthDatePicker.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(12, 66);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(60, 16);
            this.BirthDateLabel.TabIndex = 3;
            this.BirthDateLabel.Text = "Birthdate";
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(192, 100);
            this.PhoneMaskedTextBox.Mask = "(999)-000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.PhoneMaskedTextBox.TabIndex = 4;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(15, 105);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(46, 16);
            this.PhoneLabel.TabIndex = 5;
            this.PhoneLabel.Text = "Phone";
            // 
            // AddressRichTextBox
            // 
            this.AddressRichTextBox.Location = new System.Drawing.Point(192, 149);
            this.AddressRichTextBox.Name = "AddressRichTextBox";
            this.AddressRichTextBox.Size = new System.Drawing.Size(200, 96);
            this.AddressRichTextBox.TabIndex = 6;
            this.AddressRichTextBox.Text = "";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(13, 149);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(58, 16);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = "Address";
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(223, 257);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(138, 23);
            this.CreateAccountButton.TabIndex = 8;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // PhoneCheckBox
            // 
            this.PhoneCheckBox.AutoSize = true;
            this.PhoneCheckBox.Checked = true;
            this.PhoneCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PhoneCheckBox.Location = new System.Drawing.Point(398, 102);
            this.PhoneCheckBox.Name = "PhoneCheckBox";
            this.PhoneCheckBox.Size = new System.Drawing.Size(18, 17);
            this.PhoneCheckBox.TabIndex = 9;
            this.PhoneCheckBox.UseVisualStyleBackColor = true;
            this.PhoneCheckBox.CheckedChanged += new System.EventHandler(this.PhoneCheckBox_CheckedChanged);
            // 
            // AddressCheckBox
            // 
            this.AddressCheckBox.AutoSize = true;
            this.AddressCheckBox.Checked = true;
            this.AddressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddressCheckBox.Location = new System.Drawing.Point(399, 149);
            this.AddressCheckBox.Name = "AddressCheckBox";
            this.AddressCheckBox.Size = new System.Drawing.Size(18, 17);
            this.AddressCheckBox.TabIndex = 10;
            this.AddressCheckBox.UseVisualStyleBackColor = true;
            this.AddressCheckBox.CheckedChanged += new System.EventHandler(this.AddressCheckBox_CheckedChanged);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 292);
            this.Controls.Add(this.AddressCheckBox);
            this.Controls.Add(this.PhoneCheckBox);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressRichTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerNameTextbox);
            this.Name = "CreateAccountForm";
            this.Text = "Create Account Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.RichTextBox AddressRichTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.CheckBox PhoneCheckBox;
        private System.Windows.Forms.CheckBox AddressCheckBox;
    }
}