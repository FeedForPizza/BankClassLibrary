namespace WinFormsApp1
{
    partial class CreateAccount
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CustomerNameTextBox = new TextBox();
            BirthdateDateTimePicker = new DateTimePicker();
            PhoneMaskedTextBox = new MaskedTextBox();
            AddressRichTextBox = new RichTextBox();
            PhoneCheckBox = new CheckBox();
            AddressCheckBox = new CheckBox();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 101);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 57);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Birthdate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 140);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(156, 12);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(250, 27);
            CustomerNameTextBox.TabIndex = 4;
            // 
            // BirthdateDateTimePicker
            // 
            BirthdateDateTimePicker.Location = new Point(156, 52);
            BirthdateDateTimePicker.MaxDate = new DateTime(2000, 12, 31, 0, 0, 0, 0);
            BirthdateDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            BirthdateDateTimePicker.Name = "BirthdateDateTimePicker";
            BirthdateDateTimePicker.Size = new Size(250, 27);
            BirthdateDateTimePicker.TabIndex = 5;
            BirthdateDateTimePicker.Value = new DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // PhoneMaskedTextBox
            // 
            PhoneMaskedTextBox.Location = new Point(155, 94);
            PhoneMaskedTextBox.Mask = "(999)-000-0000";
            PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            PhoneMaskedTextBox.Size = new Size(251, 27);
            PhoneMaskedTextBox.TabIndex = 6;
            // 
            // AddressRichTextBox
            // 
            AddressRichTextBox.Location = new Point(155, 140);
            AddressRichTextBox.Name = "AddressRichTextBox";
            AddressRichTextBox.Size = new Size(251, 120);
            AddressRichTextBox.TabIndex = 7;
            AddressRichTextBox.Text = "";
            // 
            // PhoneCheckBox
            // 
            PhoneCheckBox.AutoSize = true;
            PhoneCheckBox.Checked = true;
            PhoneCheckBox.CheckState = CheckState.Checked;
            PhoneCheckBox.Location = new Point(412, 101);
            PhoneCheckBox.Name = "PhoneCheckBox";
            PhoneCheckBox.Size = new Size(18, 17);
            PhoneCheckBox.TabIndex = 8;
            PhoneCheckBox.UseVisualStyleBackColor = true;
            PhoneCheckBox.CheckedChanged += PhoneCheckBox_CheckedChanged;
            // 
            // AddressCheckBox
            // 
            AddressCheckBox.AutoSize = true;
            AddressCheckBox.Checked = true;
            AddressCheckBox.CheckState = CheckState.Checked;
            AddressCheckBox.Location = new Point(412, 143);
            AddressCheckBox.Name = "AddressCheckBox";
            AddressCheckBox.Size = new Size(18, 17);
            AddressCheckBox.TabIndex = 9;
            AddressCheckBox.UseVisualStyleBackColor = true;
            AddressCheckBox.CheckedChanged += AddressCheckBox_CheckedChanged;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(312, 279);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(94, 29);
            CreateButton.TabIndex = 10;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateAccountButton_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 334);
            Controls.Add(CreateButton);
            Controls.Add(AddressCheckBox);
            Controls.Add(PhoneCheckBox);
            Controls.Add(AddressRichTextBox);
            Controls.Add(PhoneMaskedTextBox);
            Controls.Add(BirthdateDateTimePicker);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateAccount";
            Text = "Create Account Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox CustomerNameTextBox;
        private DateTimePicker BirthdateDateTimePicker;
        private MaskedTextBox PhoneMaskedTextBox;
        private RichTextBox AddressRichTextBox;
        private CheckBox PhoneCheckBox;
        private CheckBox AddressCheckBox;
        private Button CreateButton;
    }
}
