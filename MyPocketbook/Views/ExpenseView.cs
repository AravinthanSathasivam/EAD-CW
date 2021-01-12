using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPocketbook.Views
{
    public partial class ExpenseView : Form
    {
        TempData temp = new TempData();
        public ExpenseView()
        {
            InitializeComponent();
            if (File.Exists(@"D:\Database\TempData.xml") == true)
            {
               // temp.ReadXml(@"D:\Database\TempData.xml");
              //  TempData.ExpenseRow data = temp.Expense[0];
              //  this.txtExpName.Text = data.Name;
              //  this.txtExpAmount.Text = data.Amount;
              //  this.txtExpDescription.Text = data.Description;
            }
        }

        private async void AddExpense(object sender, EventArgs e)
        {
            this.btnAddExpense.Enabled = false;
            //temp.Expense.Clear();
            temp.Expense.AddExpenseRow(this.txtExpName.Text, this.txtExpAmount.Text,
                this.txtExpCategory.Text, this.txtExpDate.Text, this.txtExpDescription.Text);

            //Store data into file
            try
            {
                temp.WriteXml(@"D:\Database\TempData.xml");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found: " + ex.Message);
                temp.WriteXml(@"D:\TempData.xml");
            }

            //Forward data to database
            MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
            Expense dataExpense = new Expense();
            User userdata = new User();
            dataExpense.UserId = LoginView.forwardUserID;
            dataExpense.Name = this.txtExpName.Text;
            dataExpense.Amount = this.txtExpAmount.Text;
            dataExpense.Category = this.txtExpCategory.Text;
            dataExpense.Date = this.txtExpDate.Text;
            dataExpense.Description = this.txtExpDescription.Text;
            // Using thread - Task
            var taskStoreDB = await Task.Run(
                () =>
                {
                    userdata.Expenses.Add(dataExpense);
                    database.Expenses.Add(dataExpense);
                    database.SaveChanges();
                    return true;
                }
                );
            MessageBox.Show(" Entry Saved Successfully");
            this.btnAddExpense.Enabled = true;
            ClearText();
        }

        void StoreDatabase()
        {
            //temp.Expense.Clear();
            temp.Expense.AddExpenseRow(this.txtExpName.Text, this.txtExpAmount.Text,
                this.txtExpCategory.Text, this.txtExpDate.Text, this.txtExpDescription.Text);

            //Store data into file
            try
            {
                temp.WriteXml(@"D:\Database\TempData.xml");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found: " + ex.Message);
                temp.WriteXml(@"D:\TempData.xml");
            }
            
            //Forward data to database
            MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
            Expense dataExpense = new Expense();
            User userdata = new User();
            dataExpense.UserId = LoginView.forwardUserID;
            dataExpense.Name = this.txtExpName.Text;
            dataExpense.Amount = this.txtExpAmount.Text;
            dataExpense.Category = this.txtExpCategory.Text;
            dataExpense.Date = this.txtExpDate.Text;
            dataExpense.Description = this.txtExpDescription.Text;
            userdata.Expenses.Add(dataExpense);
            database.Expenses.Add(dataExpense);
            database.SaveChanges();
        }

        void ClearText()
        {
            this.txtExpName.Text = this.txtExpAmount.Text = this.txtExpDescription.Text = "";
        }

        private void AmountValidation(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            //Validate Digit input field

            // Validate extra dot(.)
            if (input == 46 && txtExpAmount.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            //Validate ( 8-Backspace 46-Shift Out )
            if (!Char.IsDigit(input) && input != 8 && input != 46)
            {
                e.Handled = true;
            }
        }

        private void ExpenseView_Load(object sender, EventArgs e)
        {
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
