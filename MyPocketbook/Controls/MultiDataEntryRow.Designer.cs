
namespace MyPocketbook.Controls
{
    partial class MultiDataEntryRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtExpDate = new System.Windows.Forms.DateTimePicker();
            this.txtExpCategory = new System.Windows.Forms.ComboBox();
            this.txtExpAmount = new System.Windows.Forms.TextBox();
            this.txtExpDescription = new System.Windows.Forms.TextBox();
            this.txtExpName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtExpDate
            // 
            this.txtExpDate.CustomFormat = "dd-MM-yyyy";
            this.txtExpDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtExpDate.Location = new System.Drawing.Point(426, 10);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(161, 34);
            this.txtExpDate.TabIndex = 13;
            // 
            // txtExpCategory
            // 
            this.txtExpCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtExpCategory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpCategory.FormattingEnabled = true;
            this.txtExpCategory.Location = new System.Drawing.Point(607, 8);
            this.txtExpCategory.Name = "txtExpCategory";
            this.txtExpCategory.Size = new System.Drawing.Size(183, 36);
            this.txtExpCategory.TabIndex = 12;
            // 
            // txtExpAmount
            // 
            this.txtExpAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpAmount.ForeColor = System.Drawing.Color.Silver;
            this.txtExpAmount.Location = new System.Drawing.Point(244, 10);
            this.txtExpAmount.Name = "txtExpAmount";
            this.txtExpAmount.Size = new System.Drawing.Size(165, 34);
            this.txtExpAmount.TabIndex = 9;
            this.txtExpAmount.Text = "00.00";
            this.txtExpAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountValidation);
            // 
            // txtExpDescription
            // 
            this.txtExpDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDescription.ForeColor = System.Drawing.Color.Silver;
            this.txtExpDescription.Location = new System.Drawing.Point(804, 8);
            this.txtExpDescription.Multiline = true;
            this.txtExpDescription.Name = "txtExpDescription";
            this.txtExpDescription.Size = new System.Drawing.Size(219, 36);
            this.txtExpDescription.TabIndex = 10;
            this.txtExpDescription.Text = "Description";
            // 
            // txtExpName
            // 
            this.txtExpName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpName.ForeColor = System.Drawing.Color.Silver;
            this.txtExpName.Location = new System.Drawing.Point(12, 10);
            this.txtExpName.Name = "txtExpName";
            this.txtExpName.Size = new System.Drawing.Size(216, 34);
            this.txtExpName.TabIndex = 11;
            this.txtExpName.Text = "Expense Name";
            // 
            // MultiDataEntryRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.txtExpCategory);
            this.Controls.Add(this.txtExpAmount);
            this.Controls.Add(this.txtExpDescription);
            this.Controls.Add(this.txtExpName);
            this.Name = "MultiDataEntryRow";
            this.Size = new System.Drawing.Size(1035, 52);
            this.Load += new System.EventHandler(this.MultiDataEntryRow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtExpDate;
        private System.Windows.Forms.ComboBox txtExpCategory;
        private System.Windows.Forms.TextBox txtExpAmount;
        private System.Windows.Forms.TextBox txtExpDescription;
        private System.Windows.Forms.TextBox txtExpName;
    }
}
