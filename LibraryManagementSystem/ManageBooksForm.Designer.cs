namespace LibraryManagementSystem
{
    partial class ManageBooksForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.bookListLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.bookListDataGridView = new System.Windows.Forms.DataGridView();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.availableCheckbox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 42);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(71, 38);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(212, 44);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // manageTitleLabel
            // 
            this.manageTitleLabel.AutoSize = true;
            this.manageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTitleLabel.Location = new System.Drawing.Point(235, 40);
            this.manageTitleLabel.Name = "manageTitleLabel";
            this.manageTitleLabel.Size = new System.Drawing.Size(269, 42);
            this.manageTitleLabel.TabIndex = 10;
            this.manageTitleLabel.Text = "Manage Books";
            this.manageTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(72, 119);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(99, 32);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title: ";
            // 
            // authorLabel
            // 
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(72, 171);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(146, 32);
            this.authorLabel.TabIndex = 12;
            this.authorLabel.Text = "Author: ";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(398, 119);
            this.titleTextbox.Multiline = true;
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(317, 32);
            this.titleTextbox.TabIndex = 13;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(398, 171);
            this.authorTextBox.Multiline = true;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(317, 32);
            this.authorTextBox.TabIndex = 14;
            // 
            // genreLabel
            // 
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(72, 228);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(146, 32);
            this.genreLabel.TabIndex = 15;
            this.genreLabel.Text = "Genre: ";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(398, 228);
            this.genreTextBox.Multiline = true;
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(317, 32);
            this.genreTextBox.TabIndex = 16;
            // 
            // YearLabel
            // 
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(72, 284);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(264, 32);
            this.YearLabel.TabIndex = 17;
            this.YearLabel.Text = "Year Published:";
            // 
            // amountLabel
            // 
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(72, 340);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(306, 32);
            this.amountLabel.TabIndex = 18;
            this.amountLabel.Text = "Amount of Copies:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(398, 284);
            this.yearTextBox.Multiline = true;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(317, 32);
            this.yearTextBox.TabIndex = 20;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(398, 340);
            this.amountTextBox.Multiline = true;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(317, 32);
            this.amountTextBox.TabIndex = 21;
            // 
            // bookListLabel
            // 
            this.bookListLabel.AutoSize = true;
            this.bookListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListLabel.Location = new System.Drawing.Point(297, 568);
            this.bookListLabel.Name = "bookListLabel";
            this.bookListLabel.Size = new System.Drawing.Size(191, 42);
            this.bookListLabel.TabIndex = 23;
            this.bookListLabel.Text = "Books List";
            this.bookListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(195, 494);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(183, 60);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(432, 494);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(183, 60);
            this.removeButton.TabIndex = 26;
            this.removeButton.Text = "Remove Book";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // bookListDataGridView
            // 
            this.bookListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListDataGridView.Location = new System.Drawing.Point(12, 613);
            this.bookListDataGridView.Name = "bookListDataGridView";
            this.bookListDataGridView.RowHeadersWidth = 82;
            this.bookListDataGridView.RowTemplate.Height = 33;
            this.bookListDataGridView.Size = new System.Drawing.Size(749, 240);
            this.bookListDataGridView.TabIndex = 28;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(398, 391);
            this.ISBNTextBox.Multiline = true;
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(317, 32);
            this.ISBNTextBox.TabIndex = 30;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.Location = new System.Drawing.Point(72, 391);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(146, 32);
            this.ISBNLabel.TabIndex = 29;
            this.ISBNLabel.Text = "ISBN: ";
            // 
            // availableCheckbox
            // 
            this.availableCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableCheckbox.Location = new System.Drawing.Point(398, 448);
            this.availableCheckbox.Name = "availableCheckbox";
            this.availableCheckbox.Size = new System.Drawing.Size(317, 30);
            this.availableCheckbox.TabIndex = 32;
            this.availableCheckbox.Text = "Is Available";
            this.availableCheckbox.UseVisualStyleBackColor = true;
            // 
            // ManageBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 865);
            this.Controls.Add(this.availableCheckbox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.bookListDataGridView);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bookListLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.manageTitleLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ManageBooksForm";
            this.Text = "ManageBooks";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label manageTitleLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label bookListLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridView bookListDataGridView;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.CheckBox availableCheckbox;
    }
}