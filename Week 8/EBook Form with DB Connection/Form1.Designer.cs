namespace Form_Demo
{
    partial class Form1
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.addBook = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthorEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dptPubDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthorFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthorLastName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookmark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpRentalExpiration = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.chkMembership = new System.Windows.Forms.CheckBox();
            this.lblEBook_ID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(185, 44);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(558, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(106, 44);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Book Title";
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(21, 366);
            this.addBook.Margin = new System.Windows.Forms.Padding(2);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(133, 30);
            this.addBook.TabIndex = 2;
            this.addBook.Text = "Add Book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.Location = new System.Drawing.Point(83, 409);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(607, 166);
            this.lblFeedback.TabIndex = 3;
            this.lblFeedback.Text = "Feedback";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(77, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author\'s Email";
            // 
            // txtAuthorEmail
            // 
            this.txtAuthorEmail.Location = new System.Drawing.Point(185, 168);
            this.txtAuthorEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthorEmail.Name = "txtAuthorEmail";
            this.txtAuthorEmail.Size = new System.Drawing.Size(558, 22);
            this.txtAuthorEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(135, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(185, 246);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(135, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // dptPubDate
            // 
            this.dptPubDate.Location = new System.Drawing.Point(427, 246);
            this.dptPubDate.Margin = new System.Windows.Forms.Padding(2);
            this.dptPubDate.Name = "dptPubDate";
            this.dptPubDate.Size = new System.Drawing.Size(316, 22);
            this.dptPubDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(355, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "PubDate";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(45, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Author\'s First Name";
            // 
            // txtAuthorFirstName
            // 
            this.txtAuthorFirstName.Location = new System.Drawing.Point(185, 84);
            this.txtAuthorFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthorFirstName.Name = "txtAuthorFirstName";
            this.txtAuthorFirstName.Size = new System.Drawing.Size(558, 22);
            this.txtAuthorFirstName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(45, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Author\'s Last Name";
            // 
            // txtAuthorLastName
            // 
            this.txtAuthorLastName.Location = new System.Drawing.Point(185, 125);
            this.txtAuthorLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthorLastName.Name = "txtAuthorLastName";
            this.txtAuthorLastName.Size = new System.Drawing.Size(558, 22);
            this.txtAuthorLastName.TabIndex = 12;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(511, 366);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 30);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(60, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number of Pages";
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(185, 207);
            this.txtPages.Margin = new System.Windows.Forms.Padding(2);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(135, 22);
            this.txtPages.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(353, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Bookmarked Page";
            // 
            // txtBookmark
            // 
            this.txtBookmark.Location = new System.Drawing.Point(483, 210);
            this.txtBookmark.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookmark.Name = "txtBookmark";
            this.txtBookmark.Size = new System.Drawing.Size(135, 22);
            this.txtBookmark.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(304, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rental Expiration";
            // 
            // dtpRentalExpiration
            // 
            this.dtpRentalExpiration.Location = new System.Drawing.Point(427, 289);
            this.dtpRentalExpiration.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRentalExpiration.Name = "dtpRentalExpiration";
            this.dtpRentalExpiration.Size = new System.Drawing.Size(316, 22);
            this.dtpRentalExpiration.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(116, 286);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Member";
            // 
            // chkMembership
            // 
            this.chkMembership.Location = new System.Drawing.Point(185, 284);
            this.chkMembership.Name = "chkMembership";
            this.chkMembership.Size = new System.Drawing.Size(22, 23);
            this.chkMembership.TabIndex = 22;
            this.chkMembership.Text = "checkBox1";
            this.chkMembership.UseVisualStyleBackColor = true;
            // 
            // lblEBook_ID
            // 
            this.lblEBook_ID.Location = new System.Drawing.Point(100, 9);
            this.lblEBook_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEBook_ID.Name = "lblEBook_ID";
            this.lblEBook_ID.Size = new System.Drawing.Size(75, 23);
            this.lblEBook_ID.TabIndex = 23;
            this.lblEBook_ID.Text = "EBook ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(168, 366);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 30);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update Book";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(315, 366);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 30);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Book";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(21, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "EBook #: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 595);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblEBook_ID);
            this.Controls.Add(this.chkMembership);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpRentalExpiration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBookmark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAuthorLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthorFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dptPubDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthorEmail);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Label lblEBook_ID;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkMembership;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBookmark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpRentalExpiration;

        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuthorLastName;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthorFirstName;

        private System.Windows.Forms.DateTimePicker dptPubDate;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthorEmail;

        private System.Windows.Forms.Label lblFeedback;

        private System.Windows.Forms.Button addBook;

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;

        #endregion
    }
}