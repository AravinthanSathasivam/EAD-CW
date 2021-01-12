
namespace MyPocketbook.Views
{
    partial class IncomeView
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
            this.btnViewIncome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddIncome = new System.Windows.Forms.Button();
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
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewIncome
            // 
            this.btnViewIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnViewIncome.FlatAppearance.BorderSize = 0;
            this.btnViewIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIncome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewIncome.ForeColor = System.Drawing.Color.White;
            this.btnViewIncome.Location = new System.Drawing.Point(634, 15);
            this.btnViewIncome.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewIncome.Name = "btnViewIncome";
            this.btnViewIncome.Size = new System.Drawing.Size(174, 49);
            this.btnViewIncome.TabIndex = 9;
            this.btnViewIncome.Text = "View Income";
            this.btnViewIncome.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Income";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.panel5.Controls.Add(this.btnAddIncome);
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
            this.panel5.Location = new System.Drawing.Point(35, 94);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(773, 385);
            this.panel5.TabIndex = 10;
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.btnAddIncome.FlatAppearance.BorderSize = 0;
            this.btnAddIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIncome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIncome.ForeColor = System.Drawing.Color.White;
            this.btnAddIncome.Location = new System.Drawing.Point(584, 301);
            this.btnAddIncome.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(163, 49);
            this.btnAddIncome.TabIndex = 8;
            this.btnAddIncome.Text = "Add";
            this.btnAddIncome.UseVisualStyleBackColor = false;
            // 
            // txtIncDate
            // 
            this.txtIncDate.CustomFormat = "dd-MM-yyyy";
            this.txtIncDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtIncDate.Location = new System.Drawing.Point(464, 150);
            this.txtIncDate.Name = "txtIncDate";
            this.txtIncDate.Size = new System.Drawing.Size(283, 34);
            this.txtIncDate.TabIndex = 8;
            // 
            // txtIncCatagory
            // 
            this.txtIncCatagory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncCatagory.FormattingEnabled = true;
            this.txtIncCatagory.Location = new System.Drawing.Point(26, 148);
            this.txtIncCatagory.Name = "txtIncCatagory";
            this.txtIncCatagory.Size = new System.Drawing.Size(330, 36);
            this.txtIncCatagory.TabIndex = 7;
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
            // txtIncAmount
            // 
            this.txtIncAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncAmount.Location = new System.Drawing.Point(464, 55);
            this.txtIncAmount.Name = "txtIncAmount";
            this.txtIncAmount.Size = new System.Drawing.Size(283, 34);
            this.txtIncAmount.TabIndex = 6;
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
            // txtIncDescription
            // 
            this.txtIncDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncDescription.Location = new System.Drawing.Point(26, 241);
            this.txtIncDescription.Multiline = true;
            this.txtIncDescription.Name = "txtIncDescription";
            this.txtIncDescription.Size = new System.Drawing.Size(330, 109);
            this.txtIncDescription.TabIndex = 6;
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
            // txtIncName
            // 
            this.txtIncName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncName.Location = new System.Drawing.Point(26, 55);
            this.txtIncName.Name = "txtIncName";
            this.txtIncName.Size = new System.Drawing.Size(330, 34);
            this.txtIncName.TabIndex = 6;
            // 
            // lblIncomeName
            // 
            this.lblIncomeName.AutoSize = true;
            this.lblIncomeName.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeName.Location = new System.Drawing.Point(21, 24);
            this.lblIncomeName.Name = "lblIncomeName";
            this.lblIncomeName.Size = new System.Drawing.Size(133, 28);
            this.lblIncomeName.TabIndex = 5;
            this.lblIncomeName.Text = "Income Name";
            // 
            // IncomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 542);
            this.Controls.Add(this.btnViewIncome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IncomeView";
            this.Text = "IncomeView";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAddIncome;
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
    }
}