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
            this.generateInventoryReportButton = new System.Windows.Forms.Button();
            this.generateUserReportButton = new System.Windows.Forms.Button();
            this.returnToPreviousScreen = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.reportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // generateInventoryReportButton
            // 
            this.generateInventoryReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateInventoryReportButton.Location = new System.Drawing.Point(22, 32);
            this.generateInventoryReportButton.Name = "generateInventoryReportButton";
            this.generateInventoryReportButton.Size = new System.Drawing.Size(149, 76);
            this.generateInventoryReportButton.TabIndex = 0;
            this.generateInventoryReportButton.Text = "Generate Inventory Report";
            this.generateInventoryReportButton.UseVisualStyleBackColor = true;
            this.generateInventoryReportButton.Click += new System.EventHandler(this.generateInventoryReportButton_Click);
            // 
            // generateUserReportButton
            // 
            this.generateUserReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateUserReportButton.Location = new System.Drawing.Point(379, 32);
            this.generateUserReportButton.Name = "generateUserReportButton";
            this.generateUserReportButton.Size = new System.Drawing.Size(149, 76);
            this.generateUserReportButton.TabIndex = 1;
            this.generateUserReportButton.Text = "Generate User Report";
            this.generateUserReportButton.UseVisualStyleBackColor = true;
            this.generateUserReportButton.Click += new System.EventHandler(this.generateUserReportButton_Click);
            // 
            // returnToPreviousScreen
            // 
            this.returnToPreviousScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToPreviousScreen.Location = new System.Drawing.Point(22, 120);
            this.returnToPreviousScreen.Name = "returnToPreviousScreen";
            this.returnToPreviousScreen.Size = new System.Drawing.Size(114, 42);
            this.returnToPreviousScreen.TabIndex = 3;
            this.returnToPreviousScreen.Text = "Return";
            this.returnToPreviousScreen.UseVisualStyleBackColor = true;
            this.returnToPreviousScreen.Click += new System.EventHandler(this.returnToPreviousScreen_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(413, 120);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(115, 42);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // reportRichTextBox
            // 
            this.reportRichTextBox.Location = new System.Drawing.Point(22, 185);
            this.reportRichTextBox.Name = "reportRichTextBox";
            this.reportRichTextBox.Size = new System.Drawing.Size(506, 215);
            this.reportRichTextBox.TabIndex = 5;
            this.reportRichTextBox.Text = "";
            // 
            // InventoryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 412);
            this.Controls.Add(this.reportRichTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.returnToPreviousScreen);
            this.Controls.Add(this.generateUserReportButton);
            this.Controls.Add(this.generateInventoryReportButton);
            this.Name = "InventoryReportForm";
            this.Text = "InventoryReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateInventoryReportButton;
        private System.Windows.Forms.Button generateUserReportButton;
        private System.Windows.Forms.Button returnToPreviousScreen;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RichTextBox reportRichTextBox;
    }
}