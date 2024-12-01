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
            this.SuspendLayout();
            // 
            // bookListView
            // 
            this.bookListView.HideSelection = false;
            this.bookListView.Location = new System.Drawing.Point(79, 145);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(652, 264);
            this.bookListView.TabIndex = 4;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.Visible = false;
            // 
            // viewBooksButton
            // 
            this.viewBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBooksButton.Location = new System.Drawing.Point(79, 50);
            this.viewBooksButton.Name = "viewBooksButton";
            this.viewBooksButton.Size = new System.Drawing.Size(122, 49);
            this.viewBooksButton.TabIndex = 5;
            this.viewBooksButton.Text = "View Books";
            this.viewBooksButton.UseVisualStyleBackColor = true;
            this.viewBooksButton.Click += new System.EventHandler(this.viewBooksButton_Click);
            // 
            // searchBooksButton
            // 
            this.searchBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBooksButton.Location = new System.Drawing.Point(244, 50);
            this.searchBooksButton.Name = "searchBooksButton";
            this.searchBooksButton.Size = new System.Drawing.Size(122, 49);
            this.searchBooksButton.TabIndex = 6;
            this.searchBooksButton.Text = "Search Books";
            this.searchBooksButton.UseVisualStyleBackColor = true;
            this.searchBooksButton.Click += new System.EventHandler(this.searchBooksButton_Click);
            // 
            // borrowBooksButton
            // 
            this.borrowBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBooksButton.Location = new System.Drawing.Point(413, 50);
            this.borrowBooksButton.Name = "borrowBooksButton";
            this.borrowBooksButton.Size = new System.Drawing.Size(122, 49);
            this.borrowBooksButton.TabIndex = 7;
            this.borrowBooksButton.Text = "Borrow Books";
            this.borrowBooksButton.UseVisualStyleBackColor = true;
            this.borrowBooksButton.Click += new System.EventHandler(this.borrowBooksButton_Click);
            // 
            // returnBooksButton
            // 
            this.returnBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooksButton.Location = new System.Drawing.Point(609, 50);
            this.returnBooksButton.Name = "returnBooksButton";
            this.returnBooksButton.Size = new System.Drawing.Size(122, 49);
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
            this.searchByComboBox.Location = new System.Drawing.Point(109, 211);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchByComboBox.TabIndex = 9;
            this.searchByComboBox.Text = "Search";
            this.searchByComboBox.Visible = false;
            this.searchByComboBox.SelectedIndexChanged += new System.EventHandler(this.searchByComboBox_SelectedIndexChanged);
            // 
            // searchLabelPromptLabel
            // 
            this.searchLabelPromptLabel.AutoSize = true;
            this.searchLabelPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabelPromptLabel.Location = new System.Drawing.Point(106, 172);
            this.searchLabelPromptLabel.Name = "searchLabelPromptLabel";
            this.searchLabelPromptLabel.Size = new System.Drawing.Size(333, 20);
            this.searchLabelPromptLabel.TabIndex = 10;
            this.searchLabelPromptLabel.Text = "How would you like to search your book?";
            this.searchLabelPromptLabel.Visible = false;
            // 
            // queryPromptLabel
            // 
            this.queryPromptLabel.AutoSize = true;
            this.queryPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryPromptLabel.Location = new System.Drawing.Point(106, 263);
            this.queryPromptLabel.Name = "queryPromptLabel";
            this.queryPromptLabel.Size = new System.Drawing.Size(0, 20);
            this.queryPromptLabel.TabIndex = 11;
            this.queryPromptLabel.Visible = false;
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(109, 318);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(154, 20);
            this.queryTextBox.TabIndex = 12;
            this.queryTextBox.Visible = false;
            // 
            // searchBookListView
            // 
            this.searchBookListView.HideSelection = false;
            this.searchBookListView.Location = new System.Drawing.Point(459, 172);
            this.searchBookListView.Name = "searchBookListView";
            this.searchBookListView.Size = new System.Drawing.Size(272, 237);
            this.searchBookListView.TabIndex = 13;
            this.searchBookListView.UseCompatibleStateImageBehavior = false;
            this.searchBookListView.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(109, 357);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(154, 35);
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
            this.bookIdPromptLabel.Location = new System.Drawing.Point(107, 177);
            this.bookIdPromptLabel.Name = "bookIdPromptLabel";
            this.bookIdPromptLabel.Size = new System.Drawing.Size(214, 20);
            this.bookIdPromptLabel.TabIndex = 15;
            this.bookIdPromptLabel.Text = "Please enter the book id :";
            this.bookIdPromptLabel.Visible = false;
            // 
            // bookIdTextBox
            // 
            this.bookIdTextBox.Location = new System.Drawing.Point(112, 251);
            this.bookIdTextBox.Name = "bookIdTextBox";
            this.bookIdTextBox.Size = new System.Drawing.Size(154, 20);
            this.bookIdTextBox.TabIndex = 16;
            this.bookIdTextBox.Visible = false;
            // 
            // borrowBookButton
            // 
            this.borrowBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBookButton.Location = new System.Drawing.Point(112, 287);
            this.borrowBookButton.Name = "borrowBookButton";
            this.borrowBookButton.Size = new System.Drawing.Size(154, 35);
            this.borrowBookButton.TabIndex = 17;
            this.borrowBookButton.Text = "Borrow Book";
            this.borrowBookButton.UseVisualStyleBackColor = true;
            this.borrowBookButton.Visible = false;
            this.borrowBookButton.Click += new System.EventHandler(this.borrowBookButton_Click);
            // 
            // returnBookButton
            // 
            this.returnBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookButton.Location = new System.Drawing.Point(112, 287);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(154, 35);
            this.returnBookButton.TabIndex = 18;
            this.returnBookButton.Text = "Return Book";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Visible = false;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // CustomerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}