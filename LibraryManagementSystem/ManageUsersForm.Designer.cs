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
            this.SuspendLayout();
            // 
            // viewUserButton
            // 
            this.viewUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUserButton.Location = new System.Drawing.Point(48, 50);
            this.viewUserButton.Name = "viewUserButton";
            this.viewUserButton.Size = new System.Drawing.Size(150, 52);
            this.viewUserButton.TabIndex = 0;
            this.viewUserButton.Text = "View User";
            this.viewUserButton.UseVisualStyleBackColor = true;
            this.viewUserButton.Click += new System.EventHandler(this.viewUserButton_Click);
            // 
            // searchUserButton
            // 
            this.searchUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUserButton.Location = new System.Drawing.Point(264, 50);
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.Size = new System.Drawing.Size(150, 52);
            this.searchUserButton.TabIndex = 1;
            this.searchUserButton.Text = "Search User";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // removeUserButton
            // 
            this.removeUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUserButton.Location = new System.Drawing.Point(472, 50);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(150, 52);
            this.removeUserButton.TabIndex = 2;
            this.removeUserButton.Text = "Remove User";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // userListView
            // 
            this.userListView.HideSelection = false;
            this.userListView.Location = new System.Drawing.Point(48, 140);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(574, 213);
            this.userListView.TabIndex = 3;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            this.userListView.Visible = false;
            // 
            // fillFormLabel
            // 
            this.fillFormLabel.AutoSize = true;
            this.fillFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillFormLabel.Location = new System.Drawing.Point(85, 165);
            this.fillFormLabel.Name = "fillFormLabel";
            this.fillFormLabel.Size = new System.Drawing.Size(240, 20);
            this.fillFormLabel.TabIndex = 4;
            this.fillFormLabel.Text = "Please fill out the form below";
            this.fillFormLabel.Visible = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(85, 217);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(157, 20);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "Enter user name : ";
            this.userNameLabel.Visible = false;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(288, 216);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 6;
            this.nameTB.Visible = false;
            // 
            // searchUsersButton
            // 
            this.searchUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUsersButton.Location = new System.Drawing.Point(89, 282);
            this.searchUsersButton.Name = "searchUsersButton";
            this.searchUsersButton.Size = new System.Drawing.Size(299, 40);
            this.searchUsersButton.TabIndex = 7;
            this.searchUsersButton.Text = "Search User";
            this.searchUsersButton.UseVisualStyleBackColor = true;
            this.searchUsersButton.Visible = false;
            this.searchUsersButton.Click += new System.EventHandler(this.searchUsersButton_Click);
            // 
            // searchUserListView
            // 
            this.searchUserListView.HideSelection = false;
            this.searchUserListView.Location = new System.Drawing.Point(424, 140);
            this.searchUserListView.Name = "searchUserListView";
            this.searchUserListView.Size = new System.Drawing.Size(198, 213);
            this.searchUserListView.TabIndex = 8;
            this.searchUserListView.UseCompatibleStateImageBehavior = false;
            this.searchUserListView.View = System.Windows.Forms.View.Details;
            this.searchUserListView.Visible = false;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(85, 216);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(127, 20);
            this.userIdLabel.TabIndex = 9;
            this.userIdLabel.Text = "Enter User Id :";
            this.userIdLabel.Visible = false;
            // 
            // removeUsersButton
            // 
            this.removeUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUsersButton.Location = new System.Drawing.Point(89, 267);
            this.removeUsersButton.Name = "removeUsersButton";
            this.removeUsersButton.Size = new System.Drawing.Size(299, 40);
            this.removeUsersButton.TabIndex = 10;
            this.removeUsersButton.Text = "Remove User";
            this.removeUsersButton.UseVisualStyleBackColor = true;
            this.removeUsersButton.Visible = false;
            this.removeUsersButton.Click += new System.EventHandler(this.removeUsersButton_Click);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 374);
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
    }
}