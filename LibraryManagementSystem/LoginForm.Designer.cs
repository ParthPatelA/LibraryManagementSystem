namespace LibraryManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.loginPromptLabel = new System.Windows.Forms.Label();
            this.namePromptLabel = new System.Windows.Forms.Label();
            this.emailPromptLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.validateButton = new System.Windows.Forms.Button();
            this.displayMessage = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languagesComboBox = new System.Windows.Forms.ComboBox();
            this.DateControl = new LibraryManagementSystem.DateUserControl();
            this.SuspendLayout();
            // 
            // welcomeMessageLabel
            // 
            resources.ApplyResources(this.welcomeMessageLabel, "welcomeMessageLabel");
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            // 
            // loginPromptLabel
            // 
            resources.ApplyResources(this.loginPromptLabel, "loginPromptLabel");
            this.loginPromptLabel.Name = "loginPromptLabel";
            // 
            // namePromptLabel
            // 
            resources.ApplyResources(this.namePromptLabel, "namePromptLabel");
            this.namePromptLabel.Name = "namePromptLabel";
            // 
            // emailPromptLabel
            // 
            resources.ApplyResources(this.emailPromptLabel, "emailPromptLabel");
            this.emailPromptLabel.Name = "emailPromptLabel";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            // 
            // validateButton
            // 
            this.validateButton.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.validateButton, "validateButton");
            this.validateButton.Name = "validateButton";
            this.validateButton.UseVisualStyleBackColor = false;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // displayMessage
            // 
            resources.ApplyResources(this.displayMessage, "displayMessage");
            this.displayMessage.ForeColor = System.Drawing.Color.Red;
            this.displayMessage.Name = "displayMessage";
            // 
            // roleComboBox
            // 
            resources.ApplyResources(this.roleComboBox, "roleComboBox");
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            resources.GetString("roleComboBox.Items"),
            resources.GetString("roleComboBox.Items1")});
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.roleComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // languagesComboBox
            // 
            this.languagesComboBox.FormattingEnabled = true;
            this.languagesComboBox.Items.AddRange(new object[] {
            resources.GetString("languagesComboBox.Items"),
            resources.GetString("languagesComboBox.Items1"),
            resources.GetString("languagesComboBox.Items2")});
            resources.ApplyResources(this.languagesComboBox, "languagesComboBox");
            this.languagesComboBox.Name = "languagesComboBox";
            this.languagesComboBox.SelectedIndexChanged += new System.EventHandler(this.languagesComboBox_SelectedIndexChanged);
            // 
            // DateControl
            // 
            this.DateControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.DateControl, "DateControl");
            this.DateControl.Name = "DateControl";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateControl);
            this.Controls.Add(this.languagesComboBox);
            this.Controls.Add(this.languageLabel);
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
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languagesComboBox;
        private DateUserControl DateControl;
    }
}

