namespace DemoForm
{
    partial class CustomTextBoxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            CustomLabel = new Label();
            CustomTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CustomLabel);
            panel1.Controls.Add(CustomTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 34);
            panel1.TabIndex = 2;
            // 
            // CustomLabel
            // 
            CustomLabel.AutoSize = true;
            CustomLabel.Location = new Point(0, 3);
            CustomLabel.Name = "CustomLabel";
            CustomLabel.Size = new Size(50, 20);
            CustomLabel.TabIndex = 1;
            CustomLabel.Text = "label1";
            // 
            // CustomTextBox
            // 
            CustomTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CustomTextBox.Location = new Point(155, 3);
            CustomTextBox.Name = "CustomTextBox";
            CustomTextBox.Size = new Size(264, 27);
            CustomTextBox.TabIndex = 0;
            // 
            // CustomTextBoxControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CustomTextBoxControl";
            Size = new Size(419, 34);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label CustomLabel;
        private TextBox CustomTextBox;
    }
}
