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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarySystemForm));
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
            this.DateControl = new LibraryManagementSystem.DateUserControl();
            this.dateUserControl1 = new LibraryManagementSystem.DateUserControl();
            this.LibrarySummaryGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // welcomeLabel
            // 
            resources.ApplyResources(this.welcomeLabel, "welcomeLabel");
            this.welcomeLabel.Name = "welcomeLabel";
            // 
            // LibrarySummaryGroupBox
            // 
            resources.ApplyResources(this.LibrarySummaryGroupBox, "LibrarySummaryGroupBox");
            this.LibrarySummaryGroupBox.Controls.Add(this.totalUsersLabel);
            this.LibrarySummaryGroupBox.Controls.Add(this.totalBooksLabel);
            this.LibrarySummaryGroupBox.Name = "LibrarySummaryGroupBox";
            this.LibrarySummaryGroupBox.TabStop = false;
            // 
            // totalUsersLabel
            // 
            resources.ApplyResources(this.totalUsersLabel, "totalUsersLabel");
            this.totalUsersLabel.Name = "totalUsersLabel";
            // 
            // totalBooksLabel
            // 
            resources.ApplyResources(this.totalBooksLabel, "totalBooksLabel");
            this.totalBooksLabel.Name = "totalBooksLabel";
            // 
            // ManageBookButton
            // 
            resources.ApplyResources(this.ManageBookButton, "ManageBookButton");
            this.ManageBookButton.Name = "ManageBookButton";
            this.ManageBookButton.UseVisualStyleBackColor = true;
            this.ManageBookButton.Click += new System.EventHandler(this.ManageBookButton_Click);
            // 
            // ReportsButton
            // 
            resources.ApplyResources(this.ReportsButton, "ReportsButton");
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            resources.ApplyResources(this.fileToolStripMenuItem1, "fileToolStripMenuItem1");
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            resources.ApplyResources(this.logoutToolStripMenuItem, "logoutToolStripMenuItem");
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // manageUsersButton
            // 
            resources.ApplyResources(this.manageUsersButton, "manageUsersButton");
            this.manageUsersButton.Name = "manageUsersButton";
            this.manageUsersButton.UseVisualStyleBackColor = true;
            this.manageUsersButton.Click += new System.EventHandler(this.manageUsersButton_Click);
            // 
            // returnLoginFormButton
            // 
            resources.ApplyResources(this.returnLoginFormButton, "returnLoginFormButton");
            this.returnLoginFormButton.Name = "returnLoginFormButton";
            this.returnLoginFormButton.UseVisualStyleBackColor = true;
            this.returnLoginFormButton.Click += new System.EventHandler(this.returnLoginFormButton_Click);
            // 
            // DateControl
            // 
            resources.ApplyResources(this.DateControl, "DateControl");
            this.DateControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateControl.Name = "DateControl";
            // 
            // dateUserControl1
            // 
            resources.ApplyResources(this.dateUserControl1, "dateUserControl1");
            this.dateUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateUserControl1.Name = "dateUserControl1";
            // 
            // LibrarySystemForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateUserControl1);
            this.Controls.Add(this.DateControl);
            this.Controls.Add(this.returnLoginFormButton);
            this.Controls.Add(this.manageUsersButton);
            this.Controls.Add(this.ManageBookButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.LibrarySummaryGroupBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "LibrarySystemForm";
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
        private DateUserControl DateControl;
        private DateUserControl dateUserControl1;
    }
}