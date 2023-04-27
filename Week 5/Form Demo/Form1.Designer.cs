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
            this.addBook.Location = new System.Drawing.Point(278, 260);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(200, 47);
            this.addBook.TabIndex = 2;
            this.addBook.Text = "Add Book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.Location = new System.Drawing.Point(159, 336);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(629, 411);
            this.lblFeedback.TabIndex = 3;
            this.lblFeedback.Text = "Feedback";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(116, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author\'s Email";
            // 
            // txtAuthorEmail
            // 
            this.txtAuthorEmail.Location = new System.Drawing.Point(278, 130);
            this.txtAuthorEmail.Name = "txtAuthorEmail";
            this.txtAuthorEmail.Size = new System.Drawing.Size(835, 31);
            this.txtAuthorEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(203, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(278, 193);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 31);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // dptPubDate
            // 
            this.dptPubDate.Location = new System.Drawing.Point(641, 193);
            this.dptPubDate.Name = "dptPubDate";
            this.dptPubDate.Size = new System.Drawing.Size(472, 31);
            this.dptPubDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(539, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "PubDate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 929);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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