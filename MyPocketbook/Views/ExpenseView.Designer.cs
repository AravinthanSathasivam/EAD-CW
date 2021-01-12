
namespace MyPocketbook.Views
{
    partial class ExpenseView
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewExpense = new System.Windows.Forms.Button();
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.txtExpName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.txtExpDate = new System.Windows.Forms.DateTimePicker();
            this.txtExpCategory = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtExpAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.txtExpDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnMultiExpense = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Expense";
            // 
            // btnViewExpense
            // 
            this.btnViewExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnViewExpense.FlatAppearance.BorderSize = 0;
            this.btnViewExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewExpense.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewExpense.ForeColor = System.Drawing.Color.White;
            this.btnViewExpense.Location = new System.Drawing.Point(634, 15);
            this.btnViewExpense.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewExpense.Name = "btnViewExpense";
            this.btnViewExpense.Size = new System.Drawing.Size(174, 49);
            this.btnViewExpense.TabIndex = 4;
            this.btnViewExpense.Text = "View Expense";
            this.btnViewExpense.UseVisualStyleBackColor = false;
            this.btnViewExpense.Click += new System.EventHandler(this.DisplayExpenseData);
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.BackColor = System.Drawing.Color.Transparent;
            this.lblExpenseName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseName.Location = new System.Drawing.Point(21, 24);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(139, 28);
            this.lblExpenseName.TabIndex = 5;
            this.lblExpenseName.Text = "Expense Name";
            // 
            // txtExpName
            // 
            this.txtExpName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpName.Location = new System.Drawing.Point(26, 55);
            this.txtExpName.Name = "txtExpName";
            this.txtExpName.Size = new System.Drawing.Size(330, 34);
            this.txtExpName.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.panel5.Controls.Add(this.btnAddExpense);
            this.panel5.Controls.Add(this.txtExpDate);
            this.panel5.Controls.Add(this.txtExpCategory);
            this.panel5.Controls.Add(this.lblDate);
            this.panel5.Controls.Add(this.txtExpAmount);
            this.panel5.Controls.Add(this.lblAmount);
            this.panel5.Controls.Add(this.lblCatagory);
            this.panel5.Controls.Add(this.txtExpDescription);
            this.panel5.Controls.Add(this.lblDescription);
            this.panel5.Controls.Add(this.txtExpName);
            this.panel5.Controls.Add(this.lblExpenseName);
            this.panel5.Location = new System.Drawing.Point(35, 94);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(773, 385);
            this.panel5.TabIndex = 7;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnAddExpense.FlatAppearance.BorderSize = 0;
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.ForeColor = System.Drawing.Color.White;
            this.btnAddExpense.Location = new System.Drawing.Point(584, 301);
            this.btnAddExpense.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(163, 49);
            this.btnAddExpense.TabIndex = 8;
            this.btnAddExpense.Text = "Add";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.AddExpense);
            // 
            // txtExpDate
            // 
            this.txtExpDate.CustomFormat = "dd-MM-yyyy";
            this.txtExpDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtExpDate.Location = new System.Drawing.Point(464, 150);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(283, 34);
            this.txtExpDate.TabIndex = 8;
            // 
            // txtExpCategory
            // 
            this.txtExpCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtExpCategory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpCategory.FormattingEnabled = true;
            this.txtExpCategory.Location = new System.Drawing.Point(26, 148);
            this.txtExpCategory.Name = "txtExpCategory";
            this.txtExpCategory.Size = new System.Drawing.Size(330, 36);
            this.txtExpCategory.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(459, 119);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 28);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // txtExpAmount
            // 
            this.txtExpAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpAmount.Location = new System.Drawing.Point(464, 55);
            this.txtExpAmount.Name = "txtExpAmount";
            this.txtExpAmount.Size = new System.Drawing.Size(283, 34);
            this.txtExpAmount.TabIndex = 6;
            this.txtExpAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountValidation);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(459, 24);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(83, 28);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.BackColor = System.Drawing.Color.Transparent;
            this.lblCatagory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.Location = new System.Drawing.Point(21, 117);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(93, 28);
            this.lblCatagory.TabIndex = 5;
            this.lblCatagory.Text = "Catagory";
            // 
            // txtExpDescription
            // 
            this.txtExpDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDescription.Location = new System.Drawing.Point(26, 241);
            this.txtExpDescription.Multiline = true;
            this.txtExpDescription.Name = "txtExpDescription";
            this.txtExpDescription.Size = new System.Drawing.Size(330, 109);
            this.txtExpDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(21, 210);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 28);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // btnMultiExpense
            // 
            this.btnMultiExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnMultiExpense.FlatAppearance.BorderSize = 0;
            this.btnMultiExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiExpense.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiExpense.ForeColor = System.Drawing.Color.White;
            this.btnMultiExpense.Location = new System.Drawing.Point(422, 15);
            this.btnMultiExpense.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiExpense.Name = "btnMultiExpense";
            this.btnMultiExpense.Size = new System.Drawing.Size(193, 49);
            this.btnMultiExpense.TabIndex = 4;
            this.btnMultiExpense.Text = "Add Multiple Expense";
            this.btnMultiExpense.UseVisualStyleBackColor = false;
            this.btnMultiExpense.Click += new System.EventHandler(this.AddMultiExpense);
            // 
            // ExpenseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 542);
            this.Controls.Add(this.btnMultiExpense);
            this.Controls.Add(this.btnViewExpense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExpenseView";
            this.Text = "ExpenseView";
            this.Load += new System.EventHandler(this.ExpenseView_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewExpense;
        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.TextBox txtExpName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtExpAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox txtExpCategory;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.DateTimePicker txtExpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.TextBox txtExpDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnMultiExpense;
    }
}