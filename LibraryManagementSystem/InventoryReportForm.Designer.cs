namespace LibraryManagementSystem
{
    partial class InventoryReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryReportForm));
            this.generateInventoryReportButton = new System.Windows.Forms.Button();
            this.generateUserReportButton = new System.Windows.Forms.Button();
            this.returnToPreviousScreen = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.reportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DateControl = new LibraryManagementSystem.DateUserControl();
            this.SuspendLayout();
            // 
            // generateInventoryReportButton
            // 
            resources.ApplyResources(this.generateInventoryReportButton, "generateInventoryReportButton");
            this.generateInventoryReportButton.Name = "generateInventoryReportButton";
            this.generateInventoryReportButton.UseVisualStyleBackColor = true;
            this.generateInventoryReportButton.Click += new System.EventHandler(this.generateInventoryReportButton_Click);
            // 
            // generateUserReportButton
            // 
            resources.ApplyResources(this.generateUserReportButton, "generateUserReportButton");
            this.generateUserReportButton.Name = "generateUserReportButton";
            this.generateUserReportButton.UseVisualStyleBackColor = true;
            this.generateUserReportButton.Click += new System.EventHandler(this.generateUserReportButton_Click);
            // 
            // returnToPreviousScreen
            // 
            resources.ApplyResources(this.returnToPreviousScreen, "returnToPreviousScreen");
            this.returnToPreviousScreen.Name = "returnToPreviousScreen";
            this.returnToPreviousScreen.UseVisualStyleBackColor = true;
            this.returnToPreviousScreen.Click += new System.EventHandler(this.returnToPreviousScreen_Click);
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // reportRichTextBox
            // 
            resources.ApplyResources(this.reportRichTextBox, "reportRichTextBox");
            this.reportRichTextBox.Name = "reportRichTextBox";
            // 
            // DateControl
            // 
            resources.ApplyResources(this.DateControl, "DateControl");
            this.DateControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateControl.Name = "DateControl";
            // 
            // InventoryReportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateControl);
            this.Controls.Add(this.reportRichTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.returnToPreviousScreen);
            this.Controls.Add(this.generateUserReportButton);
            this.Controls.Add(this.generateInventoryReportButton);
            this.Name = "InventoryReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateInventoryReportButton;
        private System.Windows.Forms.Button generateUserReportButton;
        private System.Windows.Forms.Button returnToPreviousScreen;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RichTextBox reportRichTextBox;
        private DateUserControl DateControl;
    }
}