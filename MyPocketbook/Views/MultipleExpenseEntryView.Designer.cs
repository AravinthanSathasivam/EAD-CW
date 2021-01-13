
namespace MyPocketbook.Views
{
    partial class MultipleExpenseEntryView
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
            this.lblExpense = new System.Windows.Forms.Label();
            this.txtEntryNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntryNum)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.lblExpense.Location = new System.Drawing.Point(4, 9);
            this.lblExpense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(297, 37);
            this.lblExpense.TabIndex = 1;
            this.lblExpense.Text = "Add Multiple Expense";
            // 
            // txtEntryNum
            // 
            this.txtEntryNum.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryNum.Location = new System.Drawing.Point(268, 55);
            this.txtEntryNum.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtEntryNum.Name = "txtEntryNum";
            this.txtEntryNum.Size = new System.Drawing.Size(71, 34);
            this.txtEntryNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Number of Entries";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.btnAddExpense);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblExpense);
            this.panel1.Controls.Add(this.txtEntryNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 108);
            this.panel1.TabIndex = 4;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnAddExpense.FlatAppearance.BorderSize = 0;
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.ForeColor = System.Drawing.Color.White;
            this.btnAddExpense.Location = new System.Drawing.Point(852, 36);
            this.btnAddExpense.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(163, 49);
            this.btnAddExpense.TabIndex = 9;
            this.btnAddExpense.Text = "Add";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(367, 55);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(105, 34);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.AddExpanseRow);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(451, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 28);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(258, 9);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(83, 28);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Amount";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.BackColor = System.Drawing.Color.Transparent;
            this.lblCatagory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.Location = new System.Drawing.Point(627, 9);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(93, 28);
            this.lblCatagory.TabIndex = 12;
            this.lblCatagory.Text = "Catagory";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(829, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 28);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.BackColor = System.Drawing.Color.Transparent;
            this.lblExpenseName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseName.Location = new System.Drawing.Point(22, 9);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(139, 28);
            this.lblExpenseName.TabIndex = 14;
            this.lblExpenseName.Text = "Expense Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblAmount);
            this.panel2.Controls.Add(this.lblCatagory);
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Controls.Add(this.lblExpenseName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 51);
            this.panel2.TabIndex = 15;
            // 
            // MultipleExpenseEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultipleExpenseEntryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultipleExpenseEntryView";
            ((System.ComponentModel.ISupportInitialize)(this.txtEntryNum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.NumericUpDown txtEntryNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.Panel panel2;
    }
}