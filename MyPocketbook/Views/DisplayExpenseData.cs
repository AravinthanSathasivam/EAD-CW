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
using System.Globalization;

namespace MyPocketbook.Views
{
    public partial class DisplayExpenseData : Form
    {
        Expense expense = new Expense();
        User userdata = new User();
        public DisplayExpenseData()
        {
            InitializeComponent();
        }

        private void EditExpense(object sender, EventArgs e)
        {
            expense.Name = this.txtExpName.Text.Trim();
            expense.Amount = this.txtExpAmount.Text.Trim();
            expense.Category = this.txtExpCategory.Text.Trim();
            expense.Date = this.txtExpDate.Text.Trim();
            expense.Description = this.txtExpDescription.Text.Trim();
            using (MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1())
            {
                database.Entry(expense).State = EntityState.Modified;
                database.SaveChanges();
            }
            Clear();
            PopulateExpenseData();
            MessageBox.Show("Data Updated Succesfully!!!");
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void DeleteExpense(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete thid Data? ", 
                "Crud Operation", MessageBoxButtons.YesNo) == DialogResult.Yes ) {

                using (MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1())
                {
                    var entry = database.Entry(expense);
                    if(entry.State == EntityState.Detached)
                    {
                        database.Expenses.Attach(expense);
                        database.Expenses.Remove(expense);
                        database.SaveChanges();
                        PopulateExpenseData();
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

        void Clear()
        {
            txtExpName.Text = txtExpAmount.Text  = 
                txtExpDate.Text = txtExpDescription.Text = "";
        }

        void PopulateExpenseData()
        {
            dataGridExpense.AutoGenerateColumns = false;
            using (MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1())
            {
                //User userdata = new User();
               // var sample = userdata.Expenses.ToList<Expense>();
                
                dataGridExpense.DataSource = database.Expenses.ToList<Expense>();
            }
        }

        private void DisplayExpenseData_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            PopulateExpenseData();
            Clear();
            //Adding Expense catagories to ComboBox
            txtExpCategory.Items.Add("Travel");
            txtExpCategory.Items.Add("Food");
            txtExpCategory.Items.Add("Entertainment");
            txtExpCategory.Items.Add("Loan");
            txtExpCategory.Items.Add("Others");
            txtExpCategory.SelectedIndex = 4;
            
        }

        private void dataGridExpense_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridExpense.CurrentRow.Index != -1) 
            {
                expense.Id = Convert.ToInt32(dataGridExpense.CurrentRow.Cells["Id"].Value);
                using (MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1())
                {
                    expense = database.Expenses.Where(x => x.Id == expense.Id).FirstOrDefault();
                    // Converting String value to DateTime
                    DateTime dt = DateTime.ParseExact
                        (expense.Date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    txtExpName.Text = expense.Name;
                    txtExpAmount.Text = expense.Amount;
                    txtExpCategory.Text = expense.Category;
                    txtExpDate.Value = dt;
                    txtExpDescription.Text = expense.Description;
                }

                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
        }
    }
}
