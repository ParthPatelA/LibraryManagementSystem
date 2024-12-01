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
            this.SuspendLayout();
            // 
            // bookListView
            // 
            this.bookListView.HideSelection = false;
            this.bookListView.Location = new System.Drawing.Point(158, 279);
            this.bookListView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(1300, 504);
            this.bookListView.TabIndex = 4;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.Visible = false;
            // 
            // viewBooksButton
            // 
            this.viewBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBooksButton.Location = new System.Drawing.Point(158, 78);
            this.viewBooksButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.viewBooksButton.Name = "viewBooksButton";
            this.viewBooksButton.Size = new System.Drawing.Size(244, 94);
            this.viewBooksButton.TabIndex = 5;
            this.viewBooksButton.Text = "View Books";
            this.viewBooksButton.UseVisualStyleBackColor = true;
            this.viewBooksButton.Click += new System.EventHandler(this.viewBooksButton_Click);
            // 
            // searchBooksButton
            // 
            this.searchBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBooksButton.Location = new System.Drawing.Point(485, 78);
            this.searchBooksButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchBooksButton.Name = "searchBooksButton";
            this.searchBooksButton.Size = new System.Drawing.Size(244, 94);
            this.searchBooksButton.TabIndex = 6;
            this.searchBooksButton.Text = "Search Books";
            this.searchBooksButton.UseVisualStyleBackColor = true;
            this.searchBooksButton.Click += new System.EventHandler(this.searchBooksButton_Click);
            // 
            // borrowBooksButton
            // 
            this.borrowBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBooksButton.Location = new System.Drawing.Point(826, 78);
            this.borrowBooksButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.borrowBooksButton.Name = "borrowBooksButton";
            this.borrowBooksButton.Size = new System.Drawing.Size(244, 94);
            this.borrowBooksButton.TabIndex = 7;
            this.borrowBooksButton.Text = "Borrow Books";
            this.borrowBooksButton.UseVisualStyleBackColor = true;
            this.borrowBooksButton.Click += new System.EventHandler(this.borrowBooksButton_Click);
            // 
            // returnBooksButton
            // 
            this.returnBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooksButton.Location = new System.Drawing.Point(1214, 78);
            this.returnBooksButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.returnBooksButton.Name = "returnBooksButton";
            this.returnBooksButton.Size = new System.Drawing.Size(244, 94);
            this.returnBooksButton.TabIndex = 8;
            this.returnBooksButton.Text = "Return Books";
            this.returnBooksButton.UseVisualStyleBackColor = true;
            this.returnBooksButton.Click += new System.EventHandler(this.returnBooksButton_Click);
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Items.AddRange(new object[] {
            "genre",
            "author",
            "title"});
            this.searchByComboBox.Location = new System.Drawing.Point(218, 406);
            this.searchByComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(238, 33);
            this.searchByComboBox.TabIndex = 9;
            this.searchByComboBox.Text = "Search";
            this.searchByComboBox.Visible = false;
            this.searchByComboBox.SelectedIndexChanged += new System.EventHandler(this.searchByComboBox_SelectedIndexChanged);
            // 
            // searchLabelPromptLabel
            // 
            this.searchLabelPromptLabel.AutoSize = true;
            this.searchLabelPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabelPromptLabel.Location = new System.Drawing.Point(212, 331);
            this.searchLabelPromptLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.searchLabelPromptLabel.Name = "searchLabelPromptLabel";
            this.searchLabelPromptLabel.Size = new System.Drawing.Size(637, 37);
            this.searchLabelPromptLabel.TabIndex = 10;
            this.searchLabelPromptLabel.Text = "How would you like to search your book?";
            this.searchLabelPromptLabel.Visible = false;
            // 
            // queryPromptLabel
            // 
            this.queryPromptLabel.AutoSize = true;
            this.queryPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryPromptLabel.Location = new System.Drawing.Point(212, 506);
            this.queryPromptLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.queryPromptLabel.Name = "queryPromptLabel";
            this.queryPromptLabel.Size = new System.Drawing.Size(0, 37);
            this.queryPromptLabel.TabIndex = 11;
            this.queryPromptLabel.Visible = false;
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(218, 612);
            this.queryTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(304, 31);
            this.queryTextBox.TabIndex = 12;
            this.queryTextBox.Visible = false;
            // 
            // searchBookListView
            // 
            this.searchBookListView.HideSelection = false;
            this.searchBookListView.Location = new System.Drawing.Point(918, 331);
            this.searchBookListView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchBookListView.Name = "searchBookListView";
            this.searchBookListView.Size = new System.Drawing.Size(540, 452);
            this.searchBookListView.TabIndex = 13;
            this.searchBookListView.UseCompatibleStateImageBehavior = false;
            this.searchBookListView.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(218, 687);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(308, 67);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search Books";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // bookIdPromptLabel
            // 
            this.bookIdPromptLabel.AutoSize = true;
            this.bookIdPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIdPromptLabel.Location = new System.Drawing.Point(214, 340);
            this.bookIdPromptLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bookIdPromptLabel.Name = "bookIdPromptLabel";
            this.bookIdPromptLabel.Size = new System.Drawing.Size(404, 37);
            this.bookIdPromptLabel.TabIndex = 15;
            this.bookIdPromptLabel.Text = "Please enter the book id :";
            this.bookIdPromptLabel.Visible = false;
            // 
            // bookIdTextBox
            // 
            this.bookIdTextBox.Location = new System.Drawing.Point(224, 483);
            this.bookIdTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bookIdTextBox.Name = "bookIdTextBox";
            this.bookIdTextBox.Size = new System.Drawing.Size(304, 31);
            this.bookIdTextBox.TabIndex = 16;
            this.bookIdTextBox.Visible = false;
            // 
            // borrowBookButton
            // 
            this.borrowBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBookButton.Location = new System.Drawing.Point(224, 552);
            this.borrowBookButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.borrowBookButton.Name = "borrowBookButton";
            this.borrowBookButton.Size = new System.Drawing.Size(308, 67);
            this.borrowBookButton.TabIndex = 17;
            this.borrowBookButton.Text = "Borrow Book";
            this.borrowBookButton.UseVisualStyleBackColor = true;
            this.borrowBookButton.Visible = false;
            this.borrowBookButton.Click += new System.EventHandler(this.borrowBookButton_Click);
            // 
            // returnBookButton
            // 
            this.returnBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookButton.Location = new System.Drawing.Point(224, 552);
            this.returnBookButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(308, 67);
            this.returnBookButton.TabIndex = 18;
            this.returnBookButton.Text = "Return Book";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Visible = false;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1254, 204);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(186, 63);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.Location = new System.Drawing.Point(168, 193);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(6);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(184, 63);
            this.dashboardButton.TabIndex = 20;
            this.dashboardButton.Text = "Go Back";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // CustomerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 792);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CustomerViewForm";
            this.Text = "CustomerViewForm";
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
    }
}