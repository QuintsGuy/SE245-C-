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
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(278, 69);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(835, 31);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(159, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Book Title";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(277, 526);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(200, 47);
            this.addBook.TabIndex = 2;
            this.addBook.Text = "Add Book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.Location = new System.Drawing.Point(116, 593);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(911, 260);
            this.lblFeedback.TabIndex = 3;
            this.lblFeedback.Text = "Feedback";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(116, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author\'s Email";
            // 
            // txtAuthorEmail
            // 
            this.txtAuthorEmail.Location = new System.Drawing.Point(278, 262);
            this.txtAuthorEmail.Name = "txtAuthorEmail";
            this.txtAuthorEmail.Size = new System.Drawing.Size(835, 31);
            this.txtAuthorEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(203, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(278, 385);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 31);
            this.txtPrice.TabIndex = 6;
            // 
            // dptPubDate
            // 
            this.dptPubDate.Location = new System.Drawing.Point(641, 385);
            this.dptPubDate.Name = "dptPubDate";
            this.dptPubDate.Size = new System.Drawing.Size(472, 31);
            this.dptPubDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(532, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "PubDate";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(67, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Author\'s First Name";
            // 
            // txtAuthorFirstName
            // 
            this.txtAuthorFirstName.Location = new System.Drawing.Point(278, 131);
            this.txtAuthorFirstName.Name = "txtAuthorFirstName";
            this.txtAuthorFirstName.Size = new System.Drawing.Size(835, 31);
            this.txtAuthorFirstName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(67, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Author\'s Last Name";
            // 
            // txtAuthorLastName
            // 
            this.txtAuthorLastName.Location = new System.Drawing.Point(278, 196);
            this.txtAuthorLastName.Name = "txtAuthorLastName";
            this.txtAuthorLastName.Size = new System.Drawing.Size(835, 31);
            this.txtAuthorLastName.TabIndex = 12;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(716, 526);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 47);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(90, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number of Pages";
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(278, 323);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(200, 31);
            this.txtPages.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(530, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 36);
            this.label7.TabIndex = 18;
            this.label7.Text = "Bookmarked Page";
            // 
            // txtBookmark
            // 
            this.txtBookmark.Location = new System.Drawing.Point(725, 328);
            this.txtBookmark.Name = "txtBookmark";
            this.txtBookmark.Size = new System.Drawing.Size(200, 31);
            this.txtBookmark.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(456, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 36);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rental Expiration";
            // 
            // dtpRentalExpiration
            // 
            this.dtpRentalExpiration.Location = new System.Drawing.Point(641, 451);
            this.dtpRentalExpiration.Name = "dtpRentalExpiration";
            this.dtpRentalExpiration.Size = new System.Drawing.Size(472, 31);
            this.dtpRentalExpiration.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 929);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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