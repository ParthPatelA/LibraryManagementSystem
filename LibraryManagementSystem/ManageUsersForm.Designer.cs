namespace LibraryManagementSystem
{
    partial class ManageUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersForm));
            this.viewUserButton = new System.Windows.Forms.Button();
            this.searchUserButton = new System.Windows.Forms.Button();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.userListView = new System.Windows.Forms.ListView();
            this.fillFormLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.searchUsersButton = new System.Windows.Forms.Button();
            this.searchUserListView = new System.Windows.Forms.ListView();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.removeUsersButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DateControl = new LibraryManagementSystem.DateUserControl();
            this.SuspendLayout();
            // 
            // viewUserButton
            // 
            resources.ApplyResources(this.viewUserButton, "viewUserButton");
            this.viewUserButton.Name = "viewUserButton";
            this.viewUserButton.UseVisualStyleBackColor = true;
            this.viewUserButton.Click += new System.EventHandler(this.viewUserButton_Click);
            // 
            // searchUserButton
            // 
            resources.ApplyResources(this.searchUserButton, "searchUserButton");
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // removeUserButton
            // 
            resources.ApplyResources(this.removeUserButton, "removeUserButton");
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // userListView
            // 
            resources.ApplyResources(this.userListView, "userListView");
            this.userListView.HideSelection = false;
            this.userListView.Name = "userListView";
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            // 
            // fillFormLabel
            // 
            resources.ApplyResources(this.fillFormLabel, "fillFormLabel");
            this.fillFormLabel.Name = "fillFormLabel";
            // 
            // userNameLabel
            // 
            resources.ApplyResources(this.userNameLabel, "userNameLabel");
            this.userNameLabel.Name = "userNameLabel";
            // 
            // nameTB
            // 
            resources.ApplyResources(this.nameTB, "nameTB");
            this.nameTB.Name = "nameTB";
            // 
            // searchUsersButton
            // 
            resources.ApplyResources(this.searchUsersButton, "searchUsersButton");
            this.searchUsersButton.Name = "searchUsersButton";
            this.searchUsersButton.UseVisualStyleBackColor = true;
            this.searchUsersButton.Click += new System.EventHandler(this.searchUsersButton_Click);
            // 
            // searchUserListView
            // 
            resources.ApplyResources(this.searchUserListView, "searchUserListView");
            this.searchUserListView.HideSelection = false;
            this.searchUserListView.Name = "searchUserListView";
            this.searchUserListView.UseCompatibleStateImageBehavior = false;
            this.searchUserListView.View = System.Windows.Forms.View.Details;
            // 
            // userIdLabel
            // 
            resources.ApplyResources(this.userIdLabel, "userIdLabel");
            this.userIdLabel.Name = "userIdLabel";
            // 
            // removeUsersButton
            // 
            resources.ApplyResources(this.removeUsersButton, "removeUsersButton");
            this.removeUsersButton.Name = "removeUsersButton";
            this.removeUsersButton.UseVisualStyleBackColor = true;
            this.removeUsersButton.Click += new System.EventHandler(this.removeUsersButton_Click);
            // 
            // dashboardButton
            // 
            resources.ApplyResources(this.dashboardButton, "dashboardButton");
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DateControl
            // 
            resources.ApplyResources(this.DateControl, "DateControl");
            this.DateControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateControl.Name = "DateControl";
            // 
            // ManageUsersForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateControl);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.dashboardButton);
            this.Controls.Add(this.removeUsersButton);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.searchUserListView);
            this.Controls.Add(this.searchUsersButton);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.fillFormLabel);
            this.Controls.Add(this.userListView);
            this.Controls.Add(this.removeUserButton);
            this.Controls.Add(this.searchUserButton);
            this.Controls.Add(this.viewUserButton);
            this.Name = "ManageUsersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewUserButton;
        private System.Windows.Forms.Button searchUserButton;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.Label fillFormLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button searchUsersButton;
        private System.Windows.Forms.ListView searchUserListView;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Button removeUsersButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button ExitButton;
        private DateUserControl DateControl;
    }
}