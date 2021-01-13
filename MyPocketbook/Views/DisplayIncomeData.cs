using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPocketbook.Views
{
    public partial class DisplayIncomeData : Form
    {
        Income income = new Income();
        User userdata = new User();
        public DisplayIncomeData()
        {
            InitializeComponent();
        }

        private void EditExpense(object sender, EventArgs e)
        {
            income.Name = this.txtIncName.Text.Trim();
            income.Amount = this.txtIncAmount.Text.Trim();
            income.Category = this.txtIncCatagory.Text.Trim();
            income.Date = this.txtIncDate.Value;
            income.Descrption = this.txtIncDescription.Text.Trim();
            using (MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1())
            {
                database.Entry(income).State = EntityState.Modified;
                database.SaveChanges();
            }
            Clear();
            PopulateIncomeData();
            MessageBox.Show("Data Updated Succesfully!!!");
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void DeleteExpense(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this Data? ",
                "Crud Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1())
                {
                    var entry = database.Entry(income);
                    if (entry.State == EntityState.Detached)
                    {
                        database.Incomes.Attach(income);
                        database.Incomes.Remove(income);
                        database.SaveChanges();
                        PopulateIncomeData();
                        Clear();
                        MessageBox.Show("Deleted Successfully !!!");
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error Deleting data!! Try again Later");
                    }
                }
            }

        }

        private void dataGridExpense_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridIncome.CurrentRow.Index != -1)
            {
                income.Id = Convert.ToInt32(dataGridIncome.CurrentRow.Cells["Id"].Value);
                using (MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1())
                {
                    income = database.Incomes.Where(x => x.Id == income.Id).FirstOrDefault();
                    txtIncName.Text = income.Name;
                    txtIncAmount.Text = income.Amount;
                    txtIncCatagory.Text = income.Category;
                    txtIncDate.Value = income.Date;
                    txtIncDescription.Text = income.Descrption;
                }

                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }

        }

        private void DisplayIncomeData_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            PopulateIncomeData();
            Clear();
            //Adding Income catagories to ComboBox
            txtIncCatagory.Items.Add("Salary");
            txtIncCatagory.Items.Add("Commission");
            txtIncCatagory.Items.Add("Interest");
            txtIncCatagory.Items.Add("Gifts");
            txtIncCatagory.Items.Add("Investments");
            txtIncCatagory.Items.Add("Others");
            txtIncCatagory.SelectedIndex = 5;

        }

        void PopulateIncomeData()
        {
            dataGridIncome.AutoGenerateColumns = false;
            using (MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1())
            {

                dataGridIncome.DataSource = database.Incomes.ToList<Income>();
            }
        }

        void Clear()
        {
            txtIncName.Text = txtIncAmount.Text =
                txtIncDate.Text = txtIncDescription.Text = "";
        }
    }
}
