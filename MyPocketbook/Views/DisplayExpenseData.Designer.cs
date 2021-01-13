
namespace MyPocketbook.Views
{
    partial class DisplayExpenseData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtExpDate = new System.Windows.Forms.DateTimePicker();
            this.txtExpCategory = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtExpAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.txtExpDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtExpName = new System.Windows.Forms.TextBox();
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.dataGridExpense = new System.Windows.Forms.DataGridView();
            this.ExpenseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.btnDelete);
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
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(472, 568);
            this.panel5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Expense Details";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(209)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::MyPocketbook.Properties.Resources.edit_32;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(23, 444);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(186, 54);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.EditExpense);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(80)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::MyPocketbook.Properties.Resources.delete_32;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(250, 444);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(186, 54);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.DeleteExpense);
            // 
            // txtExpDate
            // 
            this.txtExpDate.CustomFormat = "dd-MM-yyyy";
            this.txtExpDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtExpDate.Location = new System.Drawing.Point(234, 197);
            this.txtExpDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.txtExpDate.MinDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(202, 34);
            this.txtExpDate.TabIndex = 8;
            // 
            // txtExpCategory
            // 
            this.txtExpCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtExpCategory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpCategory.FormattingEnabled = true;
            this.txtExpCategory.Location = new System.Drawing.Point(234, 119);
            this.txtExpCategory.Name = "txtExpCategory";
            this.txtExpCategory.Size = new System.Drawing.Size(202, 36);
            this.txtExpCategory.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(229, 166);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 28);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // txtExpAmount
            // 
            this.txtExpAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpAmount.Location = new System.Drawing.Point(23, 197);
            this.txtExpAmount.Name = "txtExpAmount";
            this.txtExpAmount.Size = new System.Drawing.Size(180, 34);
            this.txtExpAmount.TabIndex = 6;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(18, 166);
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
            this.lblCatagory.Location = new System.Drawing.Point(229, 88);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(93, 28);
            this.lblCatagory.TabIndex = 5;
            this.lblCatagory.Text = "Catagory";
            // 
            // txtExpDescription
            // 
            this.txtExpDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDescription.Location = new System.Drawing.Point(23, 288);
            this.txtExpDescription.Multiline = true;
            this.txtExpDescription.Name = "txtExpDescription";
            this.txtExpDescription.Size = new System.Drawing.Size(413, 109);
            this.txtExpDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(18, 257);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 28);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // txtExpName
            // 
            this.txtExpName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpName.Location = new System.Drawing.Point(23, 119);
            this.txtExpName.Name = "txtExpName";
            this.txtExpName.Size = new System.Drawing.Size(180, 34);
            this.txtExpName.TabIndex = 6;
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.BackColor = System.Drawing.Color.Transparent;
            this.lblExpenseName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseName.Location = new System.Drawing.Point(18, 88);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(139, 28);
            this.lblExpenseName.TabIndex = 5;
            this.lblExpenseName.Text = "Expense Name";
            // 
            // dataGridExpense
            // 
            this.dataGridExpense.AllowUserToDeleteRows = false;
            this.dataGridExpense.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridExpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridExpense.ColumnHeadersHeight = 40;
            this.dataGridExpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpenseName,
            this.Category,
            this.Amount,
            this.Date,
            this.Description,
            this.Id});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridExpense.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridExpense.Location = new System.Drawing.Point(495, 12);
            this.dataGridExpense.Name = "dataGridExpense";
            this.dataGridExpense.ReadOnly = true;
            this.dataGridExpense.RowHeadersVisible = false;
            this.dataGridExpense.RowHeadersWidth = 10;
            this.dataGridExpense.RowTemplate.Height = 40;
            this.dataGridExpense.Size = new System.Drawing.Size(838, 542);
            this.dataGridExpense.TabIndex = 10;
            this.dataGridExpense.DoubleClick += new System.EventHandler(this.dataGridExpense_DoubleClick);
            // 
            // ExpenseName
            // 
            this.ExpenseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpenseName.DataPropertyName = "Name";
            this.ExpenseName.HeaderText = "Expense Name";
            this.ExpenseName.MinimumWidth = 6;
            this.ExpenseName.Name = "ExpenseName";
            this.ExpenseName.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // DisplayExpenseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 568);
            this.Controls.Add(this.dataGridExpense);
            this.Controls.Add(this.panel5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayExpenseData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayExpenseData";
            this.Load += new System.EventHandler(this.DisplayExpenseData_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker txtExpDate;
        private System.Windows.Forms.ComboBox txtExpCategory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtExpAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.TextBox txtExpDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtExpName;
        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}