
namespace MyPocketbook.Views
{
    partial class DisplayIncomeData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblIncomeDetails = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtIncDate = new System.Windows.Forms.DateTimePicker();
            this.txtIncCatagory = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtIncAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.txtIncDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtIncName = new System.Windows.Forms.TextBox();
            this.lblIncomeName = new System.Windows.Forms.Label();
            this.dataGridIncome = new System.Windows.Forms.DataGridView();
            this.ExpenseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.panel5.Controls.Add(this.lblIncomeDetails);
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.txtIncDate);
            this.panel5.Controls.Add(this.txtIncCatagory);
            this.panel5.Controls.Add(this.lblDate);
            this.panel5.Controls.Add(this.txtIncAmount);
            this.panel5.Controls.Add(this.lblAmount);
            this.panel5.Controls.Add(this.lblCatagory);
            this.panel5.Controls.Add(this.txtIncDescription);
            this.panel5.Controls.Add(this.lblDescription);
            this.panel5.Controls.Add(this.txtIncName);
            this.panel5.Controls.Add(this.lblIncomeName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(472, 568);
            this.panel5.TabIndex = 10;
            // 
            // lblIncomeDetails
            // 
            this.lblIncomeDetails.AutoSize = true;
            this.lblIncomeDetails.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.lblIncomeDetails.Location = new System.Drawing.Point(16, 22);
            this.lblIncomeDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomeDetails.Name = "lblIncomeDetails";
            this.lblIncomeDetails.Size = new System.Drawing.Size(226, 41);
            this.lblIncomeDetails.TabIndex = 9;
            this.lblIncomeDetails.Text = "Income Details";
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
            // txtIncDate
            // 
            this.txtIncDate.CustomFormat = "dd-MM-yyyy";
            this.txtIncDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtIncDate.Location = new System.Drawing.Point(234, 197);
            this.txtIncDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.txtIncDate.MinDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.txtIncDate.Name = "txtIncDate";
            this.txtIncDate.Size = new System.Drawing.Size(202, 34);
            this.txtIncDate.TabIndex = 8;
            // 
            // txtIncCatagory
            // 
            this.txtIncCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtIncCatagory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncCatagory.FormattingEnabled = true;
            this.txtIncCatagory.Location = new System.Drawing.Point(234, 119);
            this.txtIncCatagory.Name = "txtIncCatagory";
            this.txtIncCatagory.Size = new System.Drawing.Size(202, 36);
            this.txtIncCatagory.TabIndex = 7;
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
            // txtIncAmount
            // 
            this.txtIncAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncAmount.Location = new System.Drawing.Point(23, 197);
            this.txtIncAmount.Name = "txtIncAmount";
            this.txtIncAmount.Size = new System.Drawing.Size(180, 34);
            this.txtIncAmount.TabIndex = 6;
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
            // txtIncDescription
            // 
            this.txtIncDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncDescription.Location = new System.Drawing.Point(23, 288);
            this.txtIncDescription.Multiline = true;
            this.txtIncDescription.Name = "txtIncDescription";
            this.txtIncDescription.Size = new System.Drawing.Size(413, 109);
            this.txtIncDescription.TabIndex = 6;
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
            // txtIncName
            // 
            this.txtIncName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncName.Location = new System.Drawing.Point(23, 119);
            this.txtIncName.Name = "txtIncName";
            this.txtIncName.Size = new System.Drawing.Size(180, 34);
            this.txtIncName.TabIndex = 6;
            // 
            // lblIncomeName
            // 
            this.lblIncomeName.AutoSize = true;
            this.lblIncomeName.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeName.Location = new System.Drawing.Point(18, 88);
            this.lblIncomeName.Name = "lblIncomeName";
            this.lblIncomeName.Size = new System.Drawing.Size(133, 28);
            this.lblIncomeName.TabIndex = 5;
            this.lblIncomeName.Text = "Income Name";
            // 
            // dataGridIncome
            // 
            this.dataGridIncome.AllowUserToDeleteRows = false;
            this.dataGridIncome.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridIncome.ColumnHeadersHeight = 40;
            this.dataGridIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpenseName,
            this.Category,
            this.Amount,
            this.Date,
            this.Description,
            this.Id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridIncome.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridIncome.Location = new System.Drawing.Point(495, 12);
            this.dataGridIncome.Name = "dataGridIncome";
            this.dataGridIncome.ReadOnly = true;
            this.dataGridIncome.RowHeadersVisible = false;
            this.dataGridIncome.RowHeadersWidth = 10;
            this.dataGridIncome.RowTemplate.Height = 40;
            this.dataGridIncome.Size = new System.Drawing.Size(838, 542);
            this.dataGridIncome.TabIndex = 11;
            this.dataGridIncome.DoubleClick += new System.EventHandler(this.dataGridExpense_DoubleClick);
            // 
            // ExpenseName
            // 
            this.ExpenseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpenseName.DataPropertyName = "Name";
            this.ExpenseName.HeaderText = "Income Name";
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
            this.Description.DataPropertyName = "Descrption";
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
            // DisplayIncomeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 568);
            this.Controls.Add(this.dataGridIncome);
            this.Controls.Add(this.panel5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayIncomeData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayIncomeData";
            this.Load += new System.EventHandler(this.DisplayIncomeData_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblIncomeDetails;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker txtIncDate;
        private System.Windows.Forms.ComboBox txtIncCatagory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtIncAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.TextBox txtIncDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtIncName;
        private System.Windows.Forms.Label lblIncomeName;
        private System.Windows.Forms.DataGridView dataGridIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}