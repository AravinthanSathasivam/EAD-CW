using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPocketbook.Views
{
    public partial class DisplayExpenseData : Form
    {
        Expense expense = new Expense();
        public DisplayExpenseData()
        {
            InitializeComponent();
        }

        private void EditExpense(object sender, EventArgs e)
        {

        }

        private void DeleteExpense(object sender, EventArgs e)
        {

        }

        void Clear()
        {
            txtExpName.Text = txtExpAmount.Text =txtExpCategory.Text = 
                txtExpDate.Text = txtExpDescription.Text = "";
;
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
    }
}
