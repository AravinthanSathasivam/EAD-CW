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
        Total total = new Total();
        public ExpenseView()
        {
            InitializeComponent();
        }

        private async void AddExpense(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtExpName.Text) ||
               String.IsNullOrEmpty(this.txtExpAmount.Text) ||
               String.IsNullOrEmpty(this.txtExpDescription.Text))

            {
                MessageBox.Show("Please Fill all the text fields", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.btnAddExpense.Enabled = false;
                //Store data into file
                try
                {
                    //temp.Expense.Clear();
                    temp.Expense.AddExpenseRow(this.txtExpName.Text, this.txtExpAmount.Text,
                    this.txtExpCategory.Text, this.txtExpDate.Text, this.txtExpDescription.Text);
                    temp.WriteXml(@"D:\TempExpenseData.xml");
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine("Directory not found: " + ex.Message);
                }


                try
                {
                    //Forward data to database
                    MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
                    Expense dataExpense = new Expense();
                    User userdata = new User();
                    dataExpense.UserId = LoginView.forwardUserID;
                    dataExpense.Name = this.txtExpName.Text.Trim();
                    dataExpense.Amount = this.txtExpAmount.Text.Trim();
                    dataExpense.Category = this.txtExpCategory.Text.Trim();
                    dataExpense.Date = this.txtExpDate.Value;
                    dataExpense.Description = this.txtExpDescription.Text.Trim();
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
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Failed to Store in the Database", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearText();

                    //Calling from file
                    if (File.Exists(@"D:\Database\TempData.xml") == true)
                    {
                       temp.ReadXml(@"D:\Database\TempData.xml");
                       TempData.ExpenseRow data = temp.Expense[0];
                       this.txtExpName.Text = data.Name;
                        this.txtExpAmount.Text = data.Amount;
                       this.txtExpDescription.Text = data.Description;
                    }
                    this.btnAddExpense.Enabled = false;
                }

            }
            

            
        }

        //Display Expense Data
        private void DisplayExpenseData(object sender, EventArgs e)
        {
            try
            {
                using (MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1())
                {
                    Console.WriteLine(!database.Expenses.Any());
                    // Checking the Expense Table is empty or not
                    if (!database.Expenses.Any())
                    {
                        MessageBox.Show("No Expense Data to display \n Enter Expense Data");
                    }
                    else
                    {
                        DisplayExpenseData displayExpense = new DisplayExpenseData();
                        displayExpense.ShowDialog();

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Database Error");
            }
        }

        //Open Multi-Expense Data Entry View
        private void AddMultiExpense(object sender, EventArgs e)
        {
            MultipleExpenseEntryView multipleExpenseEntry = new MultipleExpenseEntryView();
            multipleExpenseEntry.ShowDialog();
        }

        // Clear text feild
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
