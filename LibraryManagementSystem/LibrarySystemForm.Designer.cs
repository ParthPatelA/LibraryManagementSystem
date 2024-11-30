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
            this.dashboardMenuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.LibrarySummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalUsersLabel = new System.Windows.Forms.Label();
            this.borrowedBooksLabel = new System.Windows.Forms.Label();
            this.totalBooksLabel = new System.Windows.Forms.Label();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnSearchCatalog = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.dashboardMenuStrip.SuspendLayout();
            this.LibrarySummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardMenuStrip
            // 
            this.dashboardMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.dashboardMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.dashboardMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.toolStripMenuItem2,
            this.helpToolStripMenuItem1});
            this.dashboardMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.dashboardMenuStrip.Name = "dashboardMenuStrip";
            this.dashboardMenuStrip.Size = new System.Drawing.Size(1600, 40);
            this.dashboardMenuStrip.TabIndex = 0;
            this.dashboardMenuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.helpToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(20, 36);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(84, 36);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(212, 44);
            this.aboutToolStripMenuItem.Text = "About";
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 44);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 84);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(619, 39);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome : ";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LibrarySummaryGroupBox
            // 
            this.LibrarySummaryGroupBox.Controls.Add(this.totalUsersLabel);
            this.LibrarySummaryGroupBox.Controls.Add(this.borrowedBooksLabel);
            this.LibrarySummaryGroupBox.Controls.Add(this.totalBooksLabel);
            this.LibrarySummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibrarySummaryGroupBox.Location = new System.Drawing.Point(19, 184);
            this.LibrarySummaryGroupBox.Name = "LibrarySummaryGroupBox";
            this.LibrarySummaryGroupBox.Size = new System.Drawing.Size(682, 197);
            this.LibrarySummaryGroupBox.TabIndex = 2;
            this.LibrarySummaryGroupBox.TabStop = false;
            this.LibrarySummaryGroupBox.Text = "Library Summary";
            // 
            // totalUsersLabel
            // 
            this.totalUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUsersLabel.Location = new System.Drawing.Point(6, 89);
            this.totalUsersLabel.Name = "totalUsersLabel";
            this.totalUsersLabel.Size = new System.Drawing.Size(282, 39);
            this.totalUsersLabel.TabIndex = 2;
            this.totalUsersLabel.Text = "Total Users:";
            this.totalUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // borrowedBooksLabel
            // 
            this.borrowedBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedBooksLabel.Location = new System.Drawing.Point(6, 125);
            this.borrowedBooksLabel.Name = "borrowedBooksLabel";
            this.borrowedBooksLabel.Size = new System.Drawing.Size(282, 39);
            this.borrowedBooksLabel.TabIndex = 1;
            this.borrowedBooksLabel.Text = "Books Borrowed:";
            this.borrowedBooksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalBooksLabel
            // 
            this.totalBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBooksLabel.Location = new System.Drawing.Point(6, 50);
            this.totalBooksLabel.Name = "totalBooksLabel";
            this.totalBooksLabel.Size = new System.Drawing.Size(282, 39);
            this.totalBooksLabel.TabIndex = 0;
            this.totalBooksLabel.Text = "Total Books:";
            this.totalBooksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(827, 184);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(236, 72);
            this.btnManageBooks.TabIndex = 4;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            // 
            // btnSearchCatalog
            // 
            this.btnSearchCatalog.Location = new System.Drawing.Point(1106, 184);
            this.btnSearchCatalog.Name = "btnSearchCatalog";
            this.btnSearchCatalog.Size = new System.Drawing.Size(236, 72);
            this.btnSearchCatalog.TabIndex = 5;
            this.btnSearchCatalog.Text = "Search Catalog";
            this.btnSearchCatalog.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(827, 311);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(236, 72);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(1106, 309);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(236, 72);
            this.btnInventory.TabIndex = 7;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(31, 432);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1311, 253);
            this.contentPanel.TabIndex = 8;
            // 
            // LibrarySystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.btnSearchCatalog);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.LibrarySummaryGroupBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.dashboardMenuStrip);
            this.MainMenuStrip = this.dashboardMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LibrarySystemForm";
            this.Text = "Library System Management - Dashboard";
            this.dashboardMenuStrip.ResumeLayout(false);
            this.dashboardMenuStrip.PerformLayout();
            this.LibrarySummaryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip dashboardMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.GroupBox LibrarySummaryGroupBox;
        private System.Windows.Forms.Label totalUsersLabel;
        private System.Windows.Forms.Label borrowedBooksLabel;
        private System.Windows.Forms.Label totalBooksLabel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnSearchCatalog;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel contentPanel;
    }
}