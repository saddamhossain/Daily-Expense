namespace DailyExpenseApplication
{
    partial class DailyExpenseUI
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
            this.dailyExpenseEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.particularTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.particularLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.viewSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.maximumExpenseTextBox = new System.Windows.Forms.TextBox();
            this.totalExpenseTextBox = new System.Windows.Forms.TextBox();
            this.maximumExpenseLabel = new System.Windows.Forms.Label();
            this.totalExpenseLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.viewCategoryWiseExpenseGroupBox = new System.Windows.Forms.GroupBox();
            this.viewCategoryLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Label();
            this.viewCategoryWiseShowButton = new System.Windows.Forms.Button();
            this.viewCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.viewCategoryWiseListBox = new System.Windows.Forms.ListBox();
            this.dailyExpenseEntryGroupBox.SuspendLayout();
            this.viewSummaryGroupBox.SuspendLayout();
            this.viewCategoryWiseExpenseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailyExpenseEntryGroupBox
            // 
            this.dailyExpenseEntryGroupBox.Controls.Add(this.particularTextBox);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.categoryComboBox);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.amountTextBox);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.saveButton);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.particularLabel);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.categoryLabel);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.amountLabel);
            this.dailyExpenseEntryGroupBox.Location = new System.Drawing.Point(27, 22);
            this.dailyExpenseEntryGroupBox.Name = "dailyExpenseEntryGroupBox";
            this.dailyExpenseEntryGroupBox.Size = new System.Drawing.Size(425, 205);
            this.dailyExpenseEntryGroupBox.TabIndex = 0;
            this.dailyExpenseEntryGroupBox.TabStop = false;
            this.dailyExpenseEntryGroupBox.Text = "Daily Expense Entry";
            // 
            // particularTextBox
            // 
            this.particularTextBox.Location = new System.Drawing.Point(142, 97);
            this.particularTextBox.Multiline = true;
            this.particularTextBox.Name = "particularTextBox";
            this.particularTextBox.Size = new System.Drawing.Size(265, 45);
            this.particularTextBox.TabIndex = 6;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryComboBox.Location = new System.Drawing.Point(142, 65);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(265, 21);
            this.categoryComboBox.TabIndex = 5;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(142, 34);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(265, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(332, 163);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // particularLabel
            // 
            this.particularLabel.AutoSize = true;
            this.particularLabel.Location = new System.Drawing.Point(47, 97);
            this.particularLabel.Name = "particularLabel";
            this.particularLabel.Size = new System.Drawing.Size(51, 13);
            this.particularLabel.TabIndex = 2;
            this.particularLabel.Text = "Particular";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(49, 65);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(55, 34);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount";
            // 
            // viewSummaryGroupBox
            // 
            this.viewSummaryGroupBox.Controls.Add(this.maximumExpenseTextBox);
            this.viewSummaryGroupBox.Controls.Add(this.totalExpenseTextBox);
            this.viewSummaryGroupBox.Controls.Add(this.maximumExpenseLabel);
            this.viewSummaryGroupBox.Controls.Add(this.totalExpenseLabel);
            this.viewSummaryGroupBox.Controls.Add(this.showButton);
            this.viewSummaryGroupBox.Location = new System.Drawing.Point(27, 233);
            this.viewSummaryGroupBox.Name = "viewSummaryGroupBox";
            this.viewSummaryGroupBox.Size = new System.Drawing.Size(425, 174);
            this.viewSummaryGroupBox.TabIndex = 1;
            this.viewSummaryGroupBox.TabStop = false;
            this.viewSummaryGroupBox.Text = "View Summary";
            // 
            // maximumExpenseTextBox
            // 
            this.maximumExpenseTextBox.Location = new System.Drawing.Point(142, 111);
            this.maximumExpenseTextBox.Name = "maximumExpenseTextBox";
            this.maximumExpenseTextBox.Size = new System.Drawing.Size(265, 20);
            this.maximumExpenseTextBox.TabIndex = 4;
            // 
            // totalExpenseTextBox
            // 
            this.totalExpenseTextBox.Location = new System.Drawing.Point(142, 82);
            this.totalExpenseTextBox.Name = "totalExpenseTextBox";
            this.totalExpenseTextBox.Size = new System.Drawing.Size(265, 20);
            this.totalExpenseTextBox.TabIndex = 3;
            // 
            // maximumExpenseLabel
            // 
            this.maximumExpenseLabel.AutoSize = true;
            this.maximumExpenseLabel.Location = new System.Drawing.Point(6, 114);
            this.maximumExpenseLabel.Name = "maximumExpenseLabel";
            this.maximumExpenseLabel.Size = new System.Drawing.Size(95, 13);
            this.maximumExpenseLabel.TabIndex = 2;
            this.maximumExpenseLabel.Text = "Maximum Expense";
            // 
            // totalExpenseLabel
            // 
            this.totalExpenseLabel.AutoSize = true;
            this.totalExpenseLabel.Location = new System.Drawing.Point(26, 85);
            this.totalExpenseLabel.Name = "totalExpenseLabel";
            this.totalExpenseLabel.Size = new System.Drawing.Size(75, 13);
            this.totalExpenseLabel.TabIndex = 1;
            this.totalExpenseLabel.Text = "Total Expense";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(300, 19);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // viewCategoryWiseExpenseGroupBox
            // 
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.viewCategoryWiseListBox);
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.viewCategoryLabel);
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.totalTextBox);
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.totalButton);
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.viewCategoryWiseShowButton);
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.viewCategoryComboBox);
            this.viewCategoryWiseExpenseGroupBox.Location = new System.Drawing.Point(517, 22);
            this.viewCategoryWiseExpenseGroupBox.Name = "viewCategoryWiseExpenseGroupBox";
            this.viewCategoryWiseExpenseGroupBox.Size = new System.Drawing.Size(371, 385);
            this.viewCategoryWiseExpenseGroupBox.TabIndex = 2;
            this.viewCategoryWiseExpenseGroupBox.TabStop = false;
            this.viewCategoryWiseExpenseGroupBox.Text = "View Categorywise Expense";
            // 
            // viewCategoryLabel
            // 
            this.viewCategoryLabel.AutoSize = true;
            this.viewCategoryLabel.Location = new System.Drawing.Point(41, 41);
            this.viewCategoryLabel.Name = "viewCategoryLabel";
            this.viewCategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.viewCategoryLabel.TabIndex = 5;
            this.viewCategoryLabel.Text = "Category";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(222, 318);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(124, 20);
            this.totalTextBox.TabIndex = 4;
            // 
            // totalButton
            // 
            this.totalButton.AutoSize = true;
            this.totalButton.Location = new System.Drawing.Point(165, 325);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(31, 13);
            this.totalButton.TabIndex = 3;
            this.totalButton.Text = "Total";
            // 
            // viewCategoryWiseShowButton
            // 
            this.viewCategoryWiseShowButton.Location = new System.Drawing.Point(254, 86);
            this.viewCategoryWiseShowButton.Name = "viewCategoryWiseShowButton";
            this.viewCategoryWiseShowButton.Size = new System.Drawing.Size(75, 23);
            this.viewCategoryWiseShowButton.TabIndex = 1;
            this.viewCategoryWiseShowButton.Text = "Show";
            this.viewCategoryWiseShowButton.UseVisualStyleBackColor = true;
            this.viewCategoryWiseShowButton.Click += new System.EventHandler(this.viewCategoryWiseShowButton_Click);
            // 
            // viewCategoryComboBox
            // 
            this.viewCategoryComboBox.FormattingEnabled = true;
            this.viewCategoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.viewCategoryComboBox.Location = new System.Drawing.Point(143, 37);
            this.viewCategoryComboBox.Name = "viewCategoryComboBox";
            this.viewCategoryComboBox.Size = new System.Drawing.Size(203, 21);
            this.viewCategoryComboBox.TabIndex = 0;
            // 
            // viewCategoryWiseListBox
            // 
            this.viewCategoryWiseListBox.FormattingEnabled = true;
            this.viewCategoryWiseListBox.Location = new System.Drawing.Point(133, 110);
            this.viewCategoryWiseListBox.Name = "viewCategoryWiseListBox";
            this.viewCategoryWiseListBox.Size = new System.Drawing.Size(213, 173);
            this.viewCategoryWiseListBox.TabIndex = 6;
            // 
            // DailyExpenseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 444);
            this.Controls.Add(this.viewCategoryWiseExpenseGroupBox);
            this.Controls.Add(this.viewSummaryGroupBox);
            this.Controls.Add(this.dailyExpenseEntryGroupBox);
            this.Name = "DailyExpenseUI";
            this.Text = "Daily Expense";
            this.dailyExpenseEntryGroupBox.ResumeLayout(false);
            this.dailyExpenseEntryGroupBox.PerformLayout();
            this.viewSummaryGroupBox.ResumeLayout(false);
            this.viewSummaryGroupBox.PerformLayout();
            this.viewCategoryWiseExpenseGroupBox.ResumeLayout(false);
            this.viewCategoryWiseExpenseGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dailyExpenseEntryGroupBox;
        private System.Windows.Forms.TextBox particularTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label particularLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.GroupBox viewSummaryGroupBox;
        private System.Windows.Forms.TextBox maximumExpenseTextBox;
        private System.Windows.Forms.TextBox totalExpenseTextBox;
        private System.Windows.Forms.Label maximumExpenseLabel;
        private System.Windows.Forms.Label totalExpenseLabel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox viewCategoryWiseExpenseGroupBox;
        private System.Windows.Forms.Label viewCategoryLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalButton;
        private System.Windows.Forms.Button viewCategoryWiseShowButton;
        private System.Windows.Forms.ComboBox viewCategoryComboBox;
        private System.Windows.Forms.ListBox viewCategoryWiseListBox;
    }
}

