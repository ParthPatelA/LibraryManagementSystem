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
            this.SuspendLayout();
            // 
            // viewUserButton
            // 
            this.viewUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUserButton.Location = new System.Drawing.Point(96, 41);
            this.viewUserButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.viewUserButton.Name = "viewUserButton";
            this.viewUserButton.Size = new System.Drawing.Size(300, 100);
            this.viewUserButton.TabIndex = 0;
            this.viewUserButton.Text = "View User";
            this.viewUserButton.UseVisualStyleBackColor = true;
            this.viewUserButton.Click += new System.EventHandler(this.viewUserButton_Click);
            // 
            // searchUserButton
            // 
            this.searchUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUserButton.Location = new System.Drawing.Point(522, 41);
            this.searchUserButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.Size = new System.Drawing.Size(300, 100);
            this.searchUserButton.TabIndex = 1;
            this.searchUserButton.Text = "Search User";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // removeUserButton
            // 
            this.removeUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUserButton.Location = new System.Drawing.Point(940, 41);
            this.removeUserButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(300, 100);
            this.removeUserButton.TabIndex = 2;
            this.removeUserButton.Text = "Remove User";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // userListView
            // 
            this.userListView.HideSelection = false;
            this.userListView.Location = new System.Drawing.Point(96, 269);
            this.userListView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(1144, 406);
            this.userListView.TabIndex = 3;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            this.userListView.Visible = false;
            // 
            // fillFormLabel
            // 
            this.fillFormLabel.AutoSize = true;
            this.fillFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillFormLabel.Location = new System.Drawing.Point(170, 317);
            this.fillFormLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fillFormLabel.Name = "fillFormLabel";
            this.fillFormLabel.Size = new System.Drawing.Size(455, 37);
            this.fillFormLabel.TabIndex = 4;
            this.fillFormLabel.Text = "Please fill out the form below";
            this.fillFormLabel.Visible = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(170, 417);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(298, 37);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "Enter user name : ";
            this.userNameLabel.Visible = false;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(576, 415);
            this.nameTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(196, 31);
            this.nameTB.TabIndex = 6;
            this.nameTB.Visible = false;
            // 
            // searchUsersButton
            // 
            this.searchUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUsersButton.Location = new System.Drawing.Point(178, 542);
            this.searchUsersButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchUsersButton.Name = "searchUsersButton";
            this.searchUsersButton.Size = new System.Drawing.Size(598, 77);
            this.searchUsersButton.TabIndex = 7;
            this.searchUsersButton.Text = "Search User";
            this.searchUsersButton.UseVisualStyleBackColor = true;
            this.searchUsersButton.Visible = false;
            this.searchUsersButton.Click += new System.EventHandler(this.searchUsersButton_Click);
            // 
            // searchUserListView
            // 
            this.searchUserListView.HideSelection = false;
            this.searchUserListView.Location = new System.Drawing.Point(848, 269);
            this.searchUserListView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchUserListView.Name = "searchUserListView";
            this.searchUserListView.Size = new System.Drawing.Size(392, 406);
            this.searchUserListView.TabIndex = 8;
            this.searchUserListView.UseCompatibleStateImageBehavior = false;
            this.searchUserListView.View = System.Windows.Forms.View.Details;
            this.searchUserListView.Visible = false;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(170, 415);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(237, 37);
            this.userIdLabel.TabIndex = 9;
            this.userIdLabel.Text = "Enter User Id :";
            this.userIdLabel.Visible = false;
            // 
            // removeUsersButton
            // 
            this.removeUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUsersButton.Location = new System.Drawing.Point(178, 513);
            this.removeUsersButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.removeUsersButton.Name = "removeUsersButton";
            this.removeUsersButton.Size = new System.Drawing.Size(598, 77);
            this.removeUsersButton.TabIndex = 10;
            this.removeUsersButton.Text = "Remove User";
            this.removeUsersButton.UseVisualStyleBackColor = true;
            this.removeUsersButton.Visible = false;
            this.removeUsersButton.Click += new System.EventHandler(this.removeUsersButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.Location = new System.Drawing.Point(96, 157);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(6);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(300, 100);
            this.dashboardButton.TabIndex = 11;
            this.dashboardButton.Text = "Go Back";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(940, 157);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(6);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(300, 100);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 719);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ManageUsersForm";
            this.Text = "ManageUsersForm";
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
    }
}