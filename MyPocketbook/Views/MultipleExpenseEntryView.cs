using MyPocketbook.Controls;
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
    public partial class MultipleExpenseEntryView : Form
    {
        MyPocketbookModelContainer1 database = new MyPocketbookModelContainer1();
        Expense dataExpense = new Expense();
        User userdata = new User();
        TempData temp = new TempData();
        public MultipleExpenseEntryView()
        {
            InitializeComponent();
            this.btnAddExpense.Enabled = false;
        }

        MultiDataEntryRow[] arrEntryRow;
        
        private void AddExpanseRow(object sender, EventArgs e)
        {
            int numRows = Convert.ToInt32(this.txtEntryNum.Value);
            arrEntryRow = new MultiDataEntryRow[numRows];

            for (int i = 0; i < numRows; i++)
            {
                this.arrEntryRow[i] = new MultiDataEntryRow();
                this.arrEntryRow[i].Location = new Point(6, 140 + i * 45);
                this.Controls.Add(this.arrEntryRow[i]);
                Console.WriteLine(this.arrEntryRow[i].GetExpenseCategort());
                Console.WriteLine(this.arrEntryRow[i].GetDate());
        }
        }


        private async void AddExpenseData(object sender, EventArgs e)
        {
            this.btnAddExpense.Enabled = false;
            int numRows = Convert.ToInt32(this.txtEntryNum.Value);
            arrEntryRow = new MultiDataEntryRow[numRows];
            // Storing data to  temporary database

            Console.WriteLine(numRows);
            try
            {
                for (int i = 1; i < numRows; i++)
                {
                    //Write data into file
                    temp.Expense.AddExpenseRow(this.arrEntryRow[i].GetExpenseName(),
                        this.arrEntryRow[i].GetExpenseAmount(),
                        this.arrEntryRow[i].GetExpenseCategort(),
                       this.arrEntryRow[i].GetDate().ToString(), this.arrEntryRow[i].GetDescrption());

                    Console.WriteLine(this.arrEntryRow[i].GetExpenseName());
                    //Forward data to database
                    dataExpense.UserId = LoginView.forwardUserID;
                    dataExpense.Name = this.arrEntryRow[i].GetExpenseName();
                   // dataExpense.Amount = this.arrEntryRow[i].GetExpenseAmount();
                    dataExpense.Category = this.arrEntryRow[i].GetExpenseCategort();
                    dataExpense.Date = this.arrEntryRow[i].GetDate();
                    dataExpense.Description = this.arrEntryRow[i].GetDescrption();
                }

                temp.WriteXml(@"D:\Database\TempData.xml");

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
                this.txtEntryNum.Value = 0;
            }
            catch (Exception)
            {

                MessageBox.Show("Error!!! Failed to Store to Database");
            }
            
            
        }
    }
}
