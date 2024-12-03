namespace LibraryManagementSystem
{
    partial class CustomerViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerViewForm));
            this.bookListView = new System.Windows.Forms.ListView();
            this.viewBooksButton = new System.Windows.Forms.Button();
            this.searchBooksButton = new System.Windows.Forms.Button();
            this.borrowBooksButton = new System.Windows.Forms.Button();
            this.returnBooksButton = new System.Windows.Forms.Button();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabelPromptLabel = new System.Windows.Forms.Label();
            this.queryPromptLabel = new System.Windows.Forms.Label();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.searchBookListView = new System.Windows.Forms.ListView();
            this.searchButton = new System.Windows.Forms.Button();
            this.bookIdPromptLabel = new System.Windows.Forms.Label();
            this.bookIdTextBox = new System.Windows.Forms.TextBox();
            this.borrowBookButton = new System.Windows.Forms.Button();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.DateControl = new LibraryManagementSystem.DateUserControl();
            this.outputReturnLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookListView
            // 
            resources.ApplyResources(this.bookListView, "bookListView");
            this.bookListView.HideSelection = false;
            this.bookListView.Name = "bookListView";
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
            // 
            // viewBooksButton
            // 
            resources.ApplyResources(this.viewBooksButton, "viewBooksButton");
            this.viewBooksButton.Name = "viewBooksButton";
            this.viewBooksButton.UseVisualStyleBackColor = true;
            this.viewBooksButton.Click += new System.EventHandler(this.viewBooksButton_Click);
            // 
            // searchBooksButton
            // 
            resources.ApplyResources(this.searchBooksButton, "searchBooksButton");
            this.searchBooksButton.Name = "searchBooksButton";
            this.searchBooksButton.UseVisualStyleBackColor = true;
            this.searchBooksButton.Click += new System.EventHandler(this.searchBooksButton_Click);
            // 
            // borrowBooksButton
            // 
            resources.ApplyResources(this.borrowBooksButton, "borrowBooksButton");
            this.borrowBooksButton.Name = "borrowBooksButton";
            this.borrowBooksButton.UseVisualStyleBackColor = true;
            this.borrowBooksButton.Click += new System.EventHandler(this.borrowBooksButton_Click);
            // 
            // returnBooksButton
            // 
            resources.ApplyResources(this.returnBooksButton, "returnBooksButton");
            this.returnBooksButton.Name = "returnBooksButton";
            this.returnBooksButton.UseVisualStyleBackColor = true;
            this.returnBooksButton.Click += new System.EventHandler(this.returnBooksButton_Click);
            // 
            // searchByComboBox
            // 
            resources.ApplyResources(this.searchByComboBox, "searchByComboBox");
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Items.AddRange(new object[] {
            resources.GetString("searchByComboBox.Items"),
            resources.GetString("searchByComboBox.Items1"),
            resources.GetString("searchByComboBox.Items2")});
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.SelectedIndexChanged += new System.EventHandler(this.searchByComboBox_SelectedIndexChanged);
            // 
            // searchLabelPromptLabel
            // 
            resources.ApplyResources(this.searchLabelPromptLabel, "searchLabelPromptLabel");
            this.searchLabelPromptLabel.Name = "searchLabelPromptLabel";
            // 
            // queryPromptLabel
            // 
            resources.ApplyResources(this.queryPromptLabel, "queryPromptLabel");
            this.queryPromptLabel.Name = "queryPromptLabel";
            // 
            // queryTextBox
            // 
            resources.ApplyResources(this.queryTextBox, "queryTextBox");
            this.queryTextBox.Name = "queryTextBox";
            // 
            // searchBookListView
            // 
            resources.ApplyResources(this.searchBookListView, "searchBookListView");
            this.searchBookListView.HideSelection = false;
            this.searchBookListView.Name = "searchBookListView";
            this.searchBookListView.UseCompatibleStateImageBehavior = false;
            this.searchBookListView.View = System.Windows.Forms.View.Details;
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // bookIdPromptLabel
            // 
            resources.ApplyResources(this.bookIdPromptLabel, "bookIdPromptLabel");
            this.bookIdPromptLabel.Name = "bookIdPromptLabel";
            // 
            // bookIdTextBox
            // 
            resources.ApplyResources(this.bookIdTextBox, "bookIdTextBox");
            this.bookIdTextBox.Name = "bookIdTextBox";
            // 
            // borrowBookButton
            // 
            resources.ApplyResources(this.borrowBookButton, "borrowBookButton");
            this.borrowBookButton.Name = "borrowBookButton";
            this.borrowBookButton.UseVisualStyleBackColor = true;
            this.borrowBookButton.Click += new System.EventHandler(this.borrowBookButton_Click);
            // 
            // returnBookButton
            // 
            resources.ApplyResources(this.returnBookButton, "returnBookButton");
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dashboardButton
            // 
            resources.ApplyResources(this.dashboardButton, "dashboardButton");
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // DateControl
            // 
            resources.ApplyResources(this.DateControl, "DateControl");
            this.DateControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateControl.Name = "DateControl";
            // 
            // outputReturnLabel
            // 
            resources.ApplyResources(this.outputReturnLabel, "outputReturnLabel");
            this.outputReturnLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputReturnLabel.Name = "outputReturnLabel";
            // 
            // returnDateLabel
            // 
            resources.ApplyResources(this.returnDateLabel, "returnDateLabel");
            this.returnDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.returnDateLabel.Name = "returnDateLabel";
            // 
            // CustomerViewForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputReturnLabel);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.DateControl);
            this.Controls.Add(this.dashboardButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.borrowBookButton);
            this.Controls.Add(this.bookIdTextBox);
            this.Controls.Add(this.bookIdPromptLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBookListView);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.queryPromptLabel);
            this.Controls.Add(this.searchLabelPromptLabel);
            this.Controls.Add(this.searchByComboBox);
            this.Controls.Add(this.returnBooksButton);
            this.Controls.Add(this.borrowBooksButton);
            this.Controls.Add(this.searchBooksButton);
            this.Controls.Add(this.viewBooksButton);
            this.Controls.Add(this.bookListView);
            this.Name = "CustomerViewForm";
            this.Load += new System.EventHandler(this.CustomerViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView bookListView;
        private System.Windows.Forms.Button viewBooksButton;
        private System.Windows.Forms.Button searchBooksButton;
        private System.Windows.Forms.Button borrowBooksButton;
        private System.Windows.Forms.Button returnBooksButton;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.Label searchLabelPromptLabel;
        private System.Windows.Forms.Label queryPromptLabel;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.ListView searchBookListView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label bookIdPromptLabel;
        private System.Windows.Forms.TextBox bookIdTextBox;
        private System.Windows.Forms.Button borrowBookButton;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button dashboardButton;
        private DateUserControl DateControl;
        private System.Windows.Forms.Label outputReturnLabel;
        private System.Windows.Forms.Label returnDateLabel;
    }
}