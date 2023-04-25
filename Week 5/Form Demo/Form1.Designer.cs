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
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(278, 142);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(420, 31);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(159, 142);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Book Title";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(895, 793);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(200, 47);
            this.addBook.TabIndex = 2;
            this.addBook.Text = "Add Book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.Location = new System.Drawing.Point(69, 804);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(629, 49);
            this.lblFeedback.TabIndex = 3;
            this.lblFeedback.Text = "Feedback";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 929);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblFeedback;

        private System.Windows.Forms.Button addBook;

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;

        #endregion
    }
}