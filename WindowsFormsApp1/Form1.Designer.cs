namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.BirthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AddressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.PhoneCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birthdate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(158, 12);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.CustomerNameTextBox.TabIndex = 4;
            // 
            // BirthdateDateTimePicker
            // 
            this.BirthdateDateTimePicker.Location = new System.Drawing.Point(158, 46);
            this.BirthdateDateTimePicker.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.BirthdateDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdateDateTimePicker.Name = "BirthdateDateTimePicker";
            this.BirthdateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.BirthdateDateTimePicker.TabIndex = 5;
            this.BirthdateDateTimePicker.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(158, 83);
            this.PhoneMaskedTextBox.Mask = "(999)-000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.PhoneMaskedTextBox.TabIndex = 6;
            // 
            // AddressRichTextBox
            // 
            this.AddressRichTextBox.Location = new System.Drawing.Point(158, 121);
            this.AddressRichTextBox.Name = "AddressRichTextBox";
            this.AddressRichTextBox.Size = new System.Drawing.Size(200, 96);
            this.AddressRichTextBox.TabIndex = 7;
            this.AddressRichTextBox.Text = "";
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(283, 243);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(75, 23);
            this.CreateAccountButton.TabIndex = 8;
            this.CreateAccountButton.Text = "Create";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // PhoneCheckBox
            // 
            this.PhoneCheckBox.AutoSize = true;
            this.PhoneCheckBox.Location = new System.Drawing.Point(365, 86);
            this.PhoneCheckBox.Name = "PhoneCheckBox";
            this.PhoneCheckBox.Size = new System.Drawing.Size(18, 17);
            this.PhoneCheckBox.TabIndex = 9;
            this.PhoneCheckBox.UseVisualStyleBackColor = true;
            this.PhoneCheckBox.CheckedChanged += new System.EventHandler(this.PhoneCheckBox_CheckedChanged);
            // 
            // AddressCheckBox
            // 
            this.AddressCheckBox.AutoSize = true;
            this.AddressCheckBox.Location = new System.Drawing.Point(365, 121);
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
            this.ClientSize = new System.Drawing.Size(403, 291);
            this.Controls.Add(this.AddressCheckBox);
            this.Controls.Add(this.PhoneCheckBox);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.AddressRichTextBox);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.BirthdateDateTimePicker);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccountForm";
            this.Text = "Create Account Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.DateTimePicker BirthdateDateTimePicker;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.RichTextBox AddressRichTextBox;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.CheckBox PhoneCheckBox;
        private System.Windows.Forms.CheckBox AddressCheckBox;
    }
}

