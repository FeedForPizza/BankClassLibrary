namespace DemoForm
{
    partial class DisplayAccountForm
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
            TransactionListBox = new ListBox();
            CustomerNamePanel = new CustomTextBoxControl();
            TransactionTypePanel = new CustomTextBoxControl();
            TransactionAmountPanel = new CustomTextBoxControl();
            TransactionDatePanel = new CustomTextBoxControl();
            TransactionLocationPanel = new CustomTextBoxControl();
            CurrentBalancePanel = new CustomTextBoxControl();
            depositAmountTextBox = new TextBox();
            depositButton = new Button();
            withdrawAmountTextBox = new TextBox();
            withdrawButton = new Button();
            SuspendLayout();
            // 
            // TransactionListBox
            // 
            TransactionListBox.FormattingEnabled = true;
            TransactionListBox.Items.AddRange(new object[] { "Transaction 1 ", "Transaction 2 " });
            TransactionListBox.Location = new Point(29, 12);
            TransactionListBox.Name = "TransactionListBox";
            TransactionListBox.Size = new Size(269, 404);
            TransactionListBox.TabIndex = 0;
            TransactionListBox.SelectedIndexChanged += TransactionListBox_SelectedIndexChanged;
            // 
            // CustomerNamePanel
            // 
            CustomerNamePanel.LabelText = "Customer Name";
            CustomerNamePanel.Location = new Point(329, 12);
            CustomerNamePanel.Name = "CustomerNamePanel";
            CustomerNamePanel.Size = new Size(467, 42);
            CustomerNamePanel.TabIndex = 1;
            CustomerNamePanel.TextInput = "";
            // 
            // TransactionTypePanel
            // 
            TransactionTypePanel.LabelText = "Transaction Type";
            TransactionTypePanel.Location = new Point(329, 149);
            TransactionTypePanel.Name = "TransactionTypePanel";
            TransactionTypePanel.Size = new Size(467, 42);
            TransactionTypePanel.TabIndex = 2;
            TransactionTypePanel.TextInput = "";
            // 
            // TransactionAmountPanel
            // 
            TransactionAmountPanel.LabelText = "Transaction Amount";
            TransactionAmountPanel.Location = new Point(329, 197);
            TransactionAmountPanel.Name = "TransactionAmountPanel";
            TransactionAmountPanel.Size = new Size(467, 42);
            TransactionAmountPanel.TabIndex = 3;
            TransactionAmountPanel.TextInput = "";
            // 
            // TransactionDatePanel
            // 
            TransactionDatePanel.ImeMode = ImeMode.NoControl;
            TransactionDatePanel.LabelText = "Transaction Date ";
            TransactionDatePanel.Location = new Point(329, 245);
            TransactionDatePanel.Name = "TransactionDatePanel";
            TransactionDatePanel.Size = new Size(467, 42);
            TransactionDatePanel.TabIndex = 4;
            TransactionDatePanel.TextInput = "";
            // 
            // TransactionLocationPanel
            // 
            TransactionLocationPanel.LabelText = "Transaction Location ";
            TransactionLocationPanel.Location = new Point(329, 293);
            TransactionLocationPanel.Name = "TransactionLocationPanel";
            TransactionLocationPanel.Size = new Size(467, 42);
            TransactionLocationPanel.TabIndex = 5;
            TransactionLocationPanel.TextInput = "";
            // 
            // CurrentBalancePanel
            // 
            CurrentBalancePanel.LabelText = "Current Balance";
            CurrentBalancePanel.Location = new Point(329, 60);
            CurrentBalancePanel.Name = "CurrentBalancePanel";
            CurrentBalancePanel.Size = new Size(467, 42);
            CurrentBalancePanel.TabIndex = 6;
            CurrentBalancePanel.TextInput = "";
            // 
            // depositAmountTextBox
            // 
            depositAmountTextBox.Location = new Point(29, 422);
            depositAmountTextBox.Name = "depositAmountTextBox";
            depositAmountTextBox.Size = new Size(125, 27);
            depositAmountTextBox.TabIndex = 7;
            depositAmountTextBox.Text = "1000";
            // 
            // depositButton
            // 
            depositButton.Location = new Point(60, 455);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(94, 29);
            depositButton.TabIndex = 8;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // withdrawAmountTextBox
            // 
            withdrawAmountTextBox.Location = new Point(173, 422);
            withdrawAmountTextBox.Name = "withdrawAmountTextBox";
            withdrawAmountTextBox.Size = new Size(125, 27);
            withdrawAmountTextBox.TabIndex = 9;
            withdrawAmountTextBox.Text = "500";
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new Point(204, 455);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(94, 29);
            withdrawButton.TabIndex = 10;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // DisplayAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 500);
            Controls.Add(withdrawButton);
            Controls.Add(withdrawAmountTextBox);
            Controls.Add(depositButton);
            Controls.Add(depositAmountTextBox);
            Controls.Add(CurrentBalancePanel);
            Controls.Add(TransactionLocationPanel);
            Controls.Add(TransactionDatePanel);
            Controls.Add(TransactionAmountPanel);
            Controls.Add(TransactionTypePanel);
            Controls.Add(CustomerNamePanel);
            Controls.Add(TransactionListBox);
            Name = "DisplayAccountForm";
            Text = "Account Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox TransactionListBox;
        private CustomTextBoxControl CustomerNamePanel;
        private CustomTextBoxControl TransactionTypePanel;
        private CustomTextBoxControl TransactionAmountPanel;
        private CustomTextBoxControl TransactionDatePanel;
        private CustomTextBoxControl TransactionLocationPanel;
        private CustomTextBoxControl CurrentBalancePanel;
        private TextBox depositAmountTextBox;
        private Button depositButton;
        private TextBox withdrawAmountTextBox;
        private Button withdrawButton;
    }
}