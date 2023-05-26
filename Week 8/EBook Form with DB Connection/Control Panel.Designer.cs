using System.ComponentModel;

namespace Form_Demo
{
    partial class Control_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.btnDeleteBooks = new System.Windows.Forms.Button();
            this.btnUpdateBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(36, 29);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(115, 33);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click_1);
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Location = new System.Drawing.Point(185, 29);
            this.btnSearchBooks.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(115, 33);
            this.btnSearchBooks.TabIndex = 1;
            this.btnSearchBooks.Text = "Search Books";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // btnDeleteBooks
            // 
            this.btnDeleteBooks.Location = new System.Drawing.Point(185, 84);
            this.btnDeleteBooks.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteBooks.Name = "btnDeleteBooks";
            this.btnDeleteBooks.Size = new System.Drawing.Size(115, 33);
            this.btnDeleteBooks.TabIndex = 3;
            this.btnDeleteBooks.Text = "Delete Books";
            this.btnDeleteBooks.UseVisualStyleBackColor = true;
            this.btnDeleteBooks.Click += new System.EventHandler(this.btnDeleteBooks_Click);
            // 
            // btnUpdateBooks
            // 
            this.btnUpdateBooks.Location = new System.Drawing.Point(36, 84);
            this.btnUpdateBooks.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateBooks.Name = "btnUpdateBooks";
            this.btnUpdateBooks.Size = new System.Drawing.Size(115, 33);
            this.btnUpdateBooks.TabIndex = 2;
            this.btnUpdateBooks.Text = "Update Books";
            this.btnUpdateBooks.UseVisualStyleBackColor = true;
            this.btnUpdateBooks.Click += new System.EventHandler(this.btnUpdateBooks_Click);
            // 
            // Control_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 144);
            this.Controls.Add(this.btnDeleteBooks);
            this.Controls.Add(this.btnUpdateBooks);
            this.Controls.Add(this.btnSearchBooks);
            this.Controls.Add(this.btnAddBook);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Control_Panel";
            this.Text = "Control_Panel";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnDeleteBooks;
        private System.Windows.Forms.Button btnUpdateBooks;

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnSearchBooks;

        #endregion
    }
}