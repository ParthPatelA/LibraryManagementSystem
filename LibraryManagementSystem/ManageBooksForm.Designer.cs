namespace LibraryManagementSystem
{
    partial class ManageBooksForm
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
            this.listAllBooksButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.bookListView = new System.Windows.Forms.ListView();
            this.fillOutFormLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.copiesAvailableLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.yearPublishedLabel = new System.Windows.Forms.Label();
            this.availabilityLabel = new System.Windows.Forms.Label();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.genreTB = new System.Windows.Forms.TextBox();
            this.yearPublishedTB = new System.Windows.Forms.TextBox();
            this.isbnTB = new System.Windows.Forms.TextBox();
            this.copiesAvailableTB = new System.Windows.Forms.TextBox();
            this.availabilityTB = new System.Windows.Forms.TextBox();
            this.addBooksButton = new System.Windows.Forms.Button();
            this.bookIdLabel = new System.Windows.Forms.Label();
            this.bookIdTB = new System.Windows.Forms.TextBox();
            this.removeBooksButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listAllBooksButton
            // 
            this.listAllBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAllBooksButton.Location = new System.Drawing.Point(52, 23);
            this.listAllBooksButton.Name = "listAllBooksButton";
            this.listAllBooksButton.Size = new System.Drawing.Size(137, 45);
            this.listAllBooksButton.TabIndex = 0;
            this.listAllBooksButton.Text = "View Books";
            this.listAllBooksButton.UseVisualStyleBackColor = true;
            this.listAllBooksButton.Click += new System.EventHandler(this.listAllBooksButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.Location = new System.Drawing.Point(262, 23);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(134, 45);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // removeBookButton
            // 
            this.removeBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBookButton.Location = new System.Drawing.Point(449, 23);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(151, 45);
            this.removeBookButton.TabIndex = 2;
            this.removeBookButton.Text = "Remove Book";
            this.removeBookButton.UseVisualStyleBackColor = true;
            this.removeBookButton.Click += new System.EventHandler(this.removeBookButton_Click);
            // 
            // bookListView
            // 
            this.bookListView.HideSelection = false;
            this.bookListView.Location = new System.Drawing.Point(61, 140);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(541, 450);
            this.bookListView.TabIndex = 3;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
            this.bookListView.Visible = false;
            // 
            // fillOutFormLabel
            // 
            this.fillOutFormLabel.AutoSize = true;
            this.fillOutFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillOutFormLabel.Location = new System.Drawing.Point(84, 153);
            this.fillOutFormLabel.Name = "fillOutFormLabel";
            this.fillOutFormLabel.Size = new System.Drawing.Size(240, 20);
            this.fillOutFormLabel.TabIndex = 4;
            this.fillOutFormLabel.Text = "Please fill out the form below";
            this.fillOutFormLabel.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(84, 213);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(67, 20);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Titles : ";
            this.titleLabel.Visible = false;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(84, 264);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(87, 20);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Authors : ";
            this.authorLabel.Visible = false;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(84, 310);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(74, 20);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genre : ";
            this.genreLabel.Visible = false;
            // 
            // copiesAvailableLabel
            // 
            this.copiesAvailableLabel.AutoSize = true;
            this.copiesAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiesAvailableLabel.Location = new System.Drawing.Point(84, 446);
            this.copiesAvailableLabel.Name = "copiesAvailableLabel";
            this.copiesAvailableLabel.Size = new System.Drawing.Size(156, 20);
            this.copiesAvailableLabel.TabIndex = 8;
            this.copiesAvailableLabel.Text = "Copies Available : ";
            this.copiesAvailableLabel.Visible = false;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLabel.Location = new System.Drawing.Point(84, 398);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(66, 20);
            this.isbnLabel.TabIndex = 9;
            this.isbnLabel.Text = "ISBN : ";
            this.isbnLabel.Visible = false;
            // 
            // yearPublishedLabel
            // 
            this.yearPublishedLabel.AutoSize = true;
            this.yearPublishedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearPublishedLabel.Location = new System.Drawing.Point(84, 355);
            this.yearPublishedLabel.Name = "yearPublishedLabel";
            this.yearPublishedLabel.Size = new System.Drawing.Size(145, 20);
            this.yearPublishedLabel.TabIndex = 10;
            this.yearPublishedLabel.Text = "Year Published : ";
            this.yearPublishedLabel.Visible = false;
            // 
            // availabilityLabel
            // 
            this.availabilityLabel.AutoSize = true;
            this.availabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilityLabel.Location = new System.Drawing.Point(84, 489);
            this.availabilityLabel.Name = "availabilityLabel";
            this.availabilityLabel.Size = new System.Drawing.Size(108, 20);
            this.availabilityLabel.TabIndex = 11;
            this.availabilityLabel.Text = "Availability : ";
            this.availabilityLabel.Visible = false;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(211, 213);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(100, 20);
            this.titleTB.TabIndex = 12;
            this.titleTB.Visible = false;
            // 
            // authorTB
            // 
            this.authorTB.Location = new System.Drawing.Point(211, 264);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(100, 20);
            this.authorTB.TabIndex = 13;
            this.authorTB.Visible = false;
            // 
            // genreTB
            // 
            this.genreTB.Location = new System.Drawing.Point(211, 310);
            this.genreTB.Name = "genreTB";
            this.genreTB.Size = new System.Drawing.Size(100, 20);
            this.genreTB.TabIndex = 14;
            this.genreTB.Visible = false;
            // 
            // yearPublishedTB
            // 
            this.yearPublishedTB.Location = new System.Drawing.Point(276, 355);
            this.yearPublishedTB.Name = "yearPublishedTB";
            this.yearPublishedTB.Size = new System.Drawing.Size(100, 20);
            this.yearPublishedTB.TabIndex = 15;
            this.yearPublishedTB.Visible = false;
            // 
            // isbnTB
            // 
            this.isbnTB.Location = new System.Drawing.Point(224, 400);
            this.isbnTB.Name = "isbnTB";
            this.isbnTB.Size = new System.Drawing.Size(100, 20);
            this.isbnTB.TabIndex = 16;
            this.isbnTB.Visible = false;
            // 
            // copiesAvailableTB
            // 
            this.copiesAvailableTB.Location = new System.Drawing.Point(285, 446);
            this.copiesAvailableTB.Name = "copiesAvailableTB";
            this.copiesAvailableTB.Size = new System.Drawing.Size(100, 20);
            this.copiesAvailableTB.TabIndex = 17;
            this.copiesAvailableTB.Visible = false;
            // 
            // availabilityTB
            // 
            this.availabilityTB.Location = new System.Drawing.Point(224, 489);
            this.availabilityTB.Name = "availabilityTB";
            this.availabilityTB.Size = new System.Drawing.Size(100, 20);
            this.availabilityTB.TabIndex = 18;
            this.availabilityTB.Text = "True/False";
            this.availabilityTB.Visible = false;
            // 
            // addBooksButton
            // 
            this.addBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooksButton.Location = new System.Drawing.Point(88, 540);
            this.addBooksButton.Name = "addBooksButton";
            this.addBooksButton.Size = new System.Drawing.Size(236, 39);
            this.addBooksButton.TabIndex = 19;
            this.addBooksButton.Text = "Add Book";
            this.addBooksButton.UseVisualStyleBackColor = true;
            this.addBooksButton.Visible = false;
            this.addBooksButton.Click += new System.EventHandler(this.addBooksButton_Click);
            // 
            // bookIdLabel
            // 
            this.bookIdLabel.AutoSize = true;
            this.bookIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIdLabel.Location = new System.Drawing.Point(84, 211);
            this.bookIdLabel.Name = "bookIdLabel";
            this.bookIdLabel.Size = new System.Drawing.Size(81, 20);
            this.bookIdLabel.TabIndex = 20;
            this.bookIdLabel.Text = "BookId : ";
            this.bookIdLabel.Visible = false;
            // 
            // bookIdTB
            // 
            this.bookIdTB.Location = new System.Drawing.Point(211, 213);
            this.bookIdTB.Name = "bookIdTB";
            this.bookIdTB.Size = new System.Drawing.Size(100, 20);
            this.bookIdTB.TabIndex = 21;
            this.bookIdTB.Visible = false;
            // 
            // removeBooksButton
            // 
            this.removeBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBooksButton.Location = new System.Drawing.Point(88, 264);
            this.removeBooksButton.Name = "removeBooksButton";
            this.removeBooksButton.Size = new System.Drawing.Size(236, 39);
            this.removeBooksButton.TabIndex = 22;
            this.removeBooksButton.Text = "Remove Book";
            this.removeBooksButton.UseVisualStyleBackColor = true;
            this.removeBooksButton.Visible = false;
            this.removeBooksButton.Click += new System.EventHandler(this.removeBooksButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.Location = new System.Drawing.Point(52, 81);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(137, 45);
            this.dashboardButton.TabIndex = 23;
            this.dashboardButton.Text = "Go back";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(449, 81);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(151, 45);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ManageBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 608);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dashboardButton);
            this.Controls.Add(this.removeBooksButton);
            this.Controls.Add(this.bookIdTB);
            this.Controls.Add(this.bookIdLabel);
            this.Controls.Add(this.addBooksButton);
            this.Controls.Add(this.availabilityTB);
            this.Controls.Add(this.copiesAvailableTB);
            this.Controls.Add(this.isbnTB);
            this.Controls.Add(this.yearPublishedTB);
            this.Controls.Add(this.genreTB);
            this.Controls.Add(this.authorTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.availabilityLabel);
            this.Controls.Add(this.yearPublishedLabel);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.copiesAvailableLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.fillOutFormLabel);
            this.Controls.Add(this.bookListView);
            this.Controls.Add(this.removeBookButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.listAllBooksButton);
            this.Name = "ManageBooksForm";
            this.Text = "ManageBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listAllBooksButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.ListView bookListView;
        private System.Windows.Forms.Label fillOutFormLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label copiesAvailableLabel;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label yearPublishedLabel;
        private System.Windows.Forms.Label availabilityLabel;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.TextBox genreTB;
        private System.Windows.Forms.TextBox yearPublishedTB;
        private System.Windows.Forms.TextBox isbnTB;
        private System.Windows.Forms.TextBox copiesAvailableTB;
        private System.Windows.Forms.TextBox availabilityTB;
        private System.Windows.Forms.Button addBooksButton;
        private System.Windows.Forms.Label bookIdLabel;
        private System.Windows.Forms.TextBox bookIdTB;
        private System.Windows.Forms.Button removeBooksButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button exitButton;
    }
}