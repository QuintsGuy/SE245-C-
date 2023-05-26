using System.ComponentModel;

namespace PersonV2_Lab
{
    partial class SearchMgr
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
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(4, 135);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(1378, 447);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellDoubleClick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(4, 85);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(1377, 44);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Search People";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(657, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name: ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(716, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "ZipCode: ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(969, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email: ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(236, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "City: ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(529, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "State: ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(328, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Middle Name: ";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(962, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "Phone: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(105, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(209, 22);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(419, 19);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(219, 22);
            this.txtMiddleName.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(735, 19);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(219, 22);
            this.txtLastName.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1013, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(339, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(271, 52);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(252, 22);
            this.txtCity.TabIndex = 14;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(571, 52);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(139, 22);
            this.txtState.TabIndex = 15;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(777, 52);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(179, 22);
            this.txtZipcode.TabIndex = 16;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(1013, 52);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(194, 22);
            this.txtPhone.TabIndex = 17;
            // 
            // SearchMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 586);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvResults);
            this.Name = "SearchMgr";
            this.Text = "SearchMgr";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.DataGridView dgvResults;

        #endregion
    }
}