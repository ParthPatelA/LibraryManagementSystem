﻿namespace LibraryManagementSystem
{
    partial class LoginForm
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
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.loginPromptLabel = new System.Windows.Forms.Label();
            this.namePromptLabel = new System.Windows.Forms.Label();
            this.emailPromptLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.validateButton = new System.Windows.Forms.Button();
            this.displayMessage = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessageLabel.Location = new System.Drawing.Point(214, 60);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(406, 31);
            this.welcomeMessageLabel.TabIndex = 0;
            this.welcomeMessageLabel.Text = "Welcome to our library system";
            // 
            // loginPromptLabel
            // 
            this.loginPromptLabel.AutoSize = true;
            this.loginPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPromptLabel.Location = new System.Drawing.Point(329, 135);
            this.loginPromptLabel.Name = "loginPromptLabel";
            this.loginPromptLabel.Size = new System.Drawing.Size(148, 24);
            this.loginPromptLabel.TabIndex = 1;
            this.loginPromptLabel.Text = "Please sign-in ";
            // 
            // namePromptLabel
            // 
            this.namePromptLabel.AutoSize = true;
            this.namePromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePromptLabel.Location = new System.Drawing.Point(157, 217);
            this.namePromptLabel.Name = "namePromptLabel";
            this.namePromptLabel.Size = new System.Drawing.Size(183, 24);
            this.namePromptLabel.TabIndex = 2;
            this.namePromptLabel.Text = "Enter your name : ";
            // 
            // emailPromptLabel
            // 
            this.emailPromptLabel.AutoSize = true;
            this.emailPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailPromptLabel.Location = new System.Drawing.Point(157, 277);
            this.emailPromptLabel.Name = "emailPromptLabel";
            this.emailPromptLabel.Size = new System.Drawing.Size(181, 24);
            this.emailPromptLabel.TabIndex = 3;
            this.emailPromptLabel.Text = "Enter your email : ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(394, 222);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(226, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(394, 281);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(226, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // validateButton
            // 
            this.validateButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.validateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(269, 371);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(244, 38);
            this.validateButton.TabIndex = 6;
            this.validateButton.Text = "Validate";
            this.validateButton.UseVisualStyleBackColor = false;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // displayMessage
            // 
            this.displayMessage.AutoSize = true;
            this.displayMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMessage.ForeColor = System.Drawing.Color.Red;
            this.displayMessage.Location = new System.Drawing.Point(275, 329);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(0, 20);
            this.displayMessage.TabIndex = 7;
            // 
            // roleComboBox
            // 
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Librarian",
            "Customer"});
            this.roleComboBox.Location = new System.Drawing.Point(161, 177);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(160, 24);
            this.roleComboBox.TabIndex = 8;
            this.roleComboBox.Text = "Type of User";
            this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.roleComboBox_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.displayMessage);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.emailPromptLabel);
            this.Controls.Add(this.namePromptLabel);
            this.Controls.Add(this.loginPromptLabel);
            this.Controls.Add(this.welcomeMessageLabel);
            this.Name = "LoginForm";
            this.Text = "Libreary Management System - Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.Label loginPromptLabel;
        private System.Windows.Forms.Label namePromptLabel;
        private System.Windows.Forms.Label emailPromptLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label displayMessage;
        private System.Windows.Forms.ComboBox roleComboBox;
    }
}

