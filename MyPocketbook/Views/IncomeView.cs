using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPocketbook.Views
{
    public partial class IncomeView : Form
    {
        TempData temp = new TempData();
        public IncomeView()
        {
            InitializeComponent();
        }
        //Display Income Details 

        private void DisplayIncomeData(object sender, EventArgs e)
        {
            try
            {
                using (MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1())
                {
                    Console.WriteLine(!database.Expenses.Any());
                    // Checking the Expense Table is empty or not
                    if (!database.Incomes.Any())
                    {
                        MessageBox.Show("No Expense Data to display \n Enter Expense Data");
                    }
                    else
                    {
                        DisplayIncomeData displayIncome = new DisplayIncomeData();
                        displayIncome.ShowDialog();

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Database Error");
            }

        }

        private async void AddIncome(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtIncName.Text) ||
               String.IsNullOrEmpty(this.txtIncAmount.Text) ||
               String.IsNullOrEmpty(this.txtIncDescription.Text))

            {
                MessageBox.Show("Please Fill all the text fields", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.btnAddIncome.Enabled = false;
                //Store data into file
                try
                {
                    temp.Income.Clear();
                    temp.Income.AddIncomeRow(this.txtIncName.Text, this.txtIncAmount.Text,
                    this.txtIncCatagory.Text, this.txtIncDate.Text, this.txtIncDescription.Text);
                    temp.WriteXml(@"D:\Database\TempData.xml");
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine("Directory not found: " + ex.Message);
                }


                try
                {
                    //Forward data to database
                    MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
                    Income income = new Income();
                    User userdata = new User();
                    income.UserId = LoginView.forwardUserID;
                    income.Name = this.txtIncName.Text.Trim();
                    income.Amount = this.txtIncAmount.Text.Trim();
                    income.Category = this.txtIncCatagory.Text.Trim();
                    income.Date = this.txtIncDate.Value;
                    income.Descrption = this.txtIncDescription.Text.Trim();
                    // Using thread - Task
                    var taskStoreDB = await Task.Run(
                        () =>
                        {
                            userdata.Incomes.Add(income);
                            database.Incomes.Add(income);
                            database.SaveChanges();
                            return true;
                        }
                        );
                    MessageBox.Show(" Entry Saved Successfully");
                    this.btnAddIncome.Enabled = true;
                    ClearText();

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Failed to Store in the Database", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearText();
                    this.btnAddIncome.Enabled = false;
                }

            }

        }

        // Clear text feild
        void ClearText()
        {
            this.txtIncName.Text = this.txtIncAmount.Text = this.txtIncDescription.Text = "";
        }

        private void IncomeView_Load(object sender, EventArgs e)
        {
            //Adding Income catagories to ComboBox
            txtIncCatagory.Items.Add("Salary");
            txtIncCatagory.Items.Add("Commission");
            txtIncCatagory.Items.Add("Interest");
            txtIncCatagory.Items.Add("Gifts");
            txtIncCatagory.Items.Add("Investments");
            txtIncCatagory.Items.Add("Others");
            txtIncCatagory.SelectedIndex = 5;
        }

        private void AmountValidation(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            //Validate Digit input field

            // Validate extra dot(.)
            if (input == 46 && txtIncAmount.Text.IndexOf('.') != -1)
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
    }
}
