namespace LibraryManagementSystem
{
    partial class LibrarySystemForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.LibrarySummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalUsersLabel = new System.Windows.Forms.Label();
            this.totalBooksLabel = new System.Windows.Forms.Label();
            this.ManageBookButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersButton = new System.Windows.Forms.Button();
            this.returnLoginFormButton = new System.Windows.Forms.Button();
            this.LibrarySummaryGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(242, 38);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 22);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 44);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(310, 20);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome : ";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LibrarySummaryGroupBox
            // 
            this.LibrarySummaryGroupBox.Controls.Add(this.totalUsersLabel);
            this.LibrarySummaryGroupBox.Controls.Add(this.totalBooksLabel);
            this.LibrarySummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibrarySummaryGroupBox.Location = new System.Drawing.Point(10, 96);
            this.LibrarySummaryGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.LibrarySummaryGroupBox.Name = "LibrarySummaryGroupBox";
            this.LibrarySummaryGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.LibrarySummaryGroupBox.Size = new System.Drawing.Size(341, 76);
            this.LibrarySummaryGroupBox.TabIndex = 2;
            this.LibrarySummaryGroupBox.TabStop = false;
            this.LibrarySummaryGroupBox.Text = "Library Summary";
            // 
            // totalUsersLabel
            // 
            this.totalUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUsersLabel.Location = new System.Drawing.Point(3, 46);
            this.totalUsersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalUsersLabel.Name = "totalUsersLabel";
            this.totalUsersLabel.Size = new System.Drawing.Size(141, 20);
            this.totalUsersLabel.TabIndex = 2;
            this.totalUsersLabel.Text = "Total Users:";
            this.totalUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalBooksLabel
            // 
            this.totalBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBooksLabel.Location = new System.Drawing.Point(3, 26);
            this.totalBooksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalBooksLabel.Name = "totalBooksLabel";
            this.totalBooksLabel.Size = new System.Drawing.Size(141, 20);
            this.totalBooksLabel.TabIndex = 0;
            this.totalBooksLabel.Text = "Total Books:";
            this.totalBooksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManageBookButton
            // 
            this.ManageBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBookButton.Location = new System.Drawing.Point(48, 194);
            this.ManageBookButton.Margin = new System.Windows.Forms.Padding(2);
            this.ManageBookButton.Name = "ManageBookButton";
            this.ManageBookButton.Size = new System.Drawing.Size(254, 37);
            this.ManageBookButton.TabIndex = 4;
            this.ManageBookButton.Text = "Manage Books";
            this.ManageBookButton.UseVisualStyleBackColor = true;
            this.ManageBookButton.Click += new System.EventHandler(this.ManageBookButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsButton.Location = new System.Drawing.Point(48, 307);
            this.ReportsButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(254, 37);
            this.ReportsButton.TabIndex = 6;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(366, 26);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // manageUsersButton
            // 
            this.manageUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersButton.Location = new System.Drawing.Point(48, 253);
            this.manageUsersButton.Margin = new System.Windows.Forms.Padding(2);
            this.manageUsersButton.Name = "manageUsersButton";
            this.manageUsersButton.Size = new System.Drawing.Size(254, 37);
            this.manageUsersButton.TabIndex = 9;
            this.manageUsersButton.Text = "Manage Users";
            this.manageUsersButton.UseVisualStyleBackColor = true;
            this.manageUsersButton.Click += new System.EventHandler(this.manageUsersButton_Click);
            // 
            // returnLoginFormButton
            // 
            this.returnLoginFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLoginFormButton.Location = new System.Drawing.Point(48, 366);
            this.returnLoginFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnLoginFormButton.Name = "returnLoginFormButton";
            this.returnLoginFormButton.Size = new System.Drawing.Size(254, 37);
            this.returnLoginFormButton.TabIndex = 11;
            this.returnLoginFormButton.Text = "Return to login form";
            this.returnLoginFormButton.UseVisualStyleBackColor = true;
            this.returnLoginFormButton.Click += new System.EventHandler(this.returnLoginFormButton_Click);
            // 
            // LibrarySystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 410);
            this.Controls.Add(this.returnLoginFormButton);
            this.Controls.Add(this.manageUsersButton);
            this.Controls.Add(this.ManageBookButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.LibrarySummaryGroupBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "LibrarySystemForm";
            this.Text = "Library System Management - Dashboard";
            this.Load += new System.EventHandler(this.LibrarySystemForm_Load);
            this.LibrarySummaryGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.GroupBox LibrarySummaryGroupBox;
        private System.Windows.Forms.Label totalUsersLabel;
        private System.Windows.Forms.Label totalBooksLabel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button ManageBookButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button manageUsersButton;
        private System.Windows.Forms.Button returnLoginFormButton;
    }
}