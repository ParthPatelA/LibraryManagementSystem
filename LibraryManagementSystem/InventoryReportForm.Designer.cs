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
            this.reportListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // generateInventoryReportButton
            // 
            this.generateInventoryReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateInventoryReportButton.Location = new System.Drawing.Point(104, 51);
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
            this.generateUserReportButton.Location = new System.Drawing.Point(357, 51);
            this.generateUserReportButton.Name = "generateUserReportButton";
            this.generateUserReportButton.Size = new System.Drawing.Size(149, 76);
            this.generateUserReportButton.TabIndex = 1;
            this.generateUserReportButton.Text = "Generate User Report";
            this.generateUserReportButton.UseVisualStyleBackColor = true;
            this.generateUserReportButton.Click += new System.EventHandler(this.generateUserReportButton_Click);
            // 
            // reportListView
            // 
            this.reportListView.HideSelection = false;
            this.reportListView.Location = new System.Drawing.Point(104, 145);
            this.reportListView.Name = "reportListView";
            this.reportListView.Size = new System.Drawing.Size(402, 200);
            this.reportListView.TabIndex = 2;
            this.reportListView.UseCompatibleStateImageBehavior = false;
            // 
            // InventoryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 357);
            this.Controls.Add(this.reportListView);
            this.Controls.Add(this.generateUserReportButton);
            this.Controls.Add(this.generateInventoryReportButton);
            this.Name = "InventoryReportForm";
            this.Text = "InventoryReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateInventoryReportButton;
        private System.Windows.Forms.Button generateUserReportButton;
        private System.Windows.Forms.ListView reportListView;
    }
}